using Cz.Project.Abstraction.Exceptions;
using Cz.Project.Domain;
using Cz.Project.Dto.Enums;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.Services;
using Cz.Project.Services.Simulator;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class OrderManagementForm : Form, ICookingNotifier
    {
        public CookingSimulator cookingSimulator;
        public bool UpdateView = false;

        public OrderManagementForm()
        {
            InitializeComponent();
            cookingSimulator = CookingSimulator.GetInstance();
            cookingSimulator.Attach(this);
            cookingSimulator.StartProcess();
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                SelectedCellHandle();
                this.UpdateView = true;
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado");
            }
        }

        private void OrderManagementForm_Shown(object sender, EventArgs e)
        {
            this.colorDgv();
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetSelectedOrder();

                new OrderService().ChangeOrderStatus(order.Id, StatusCodeEnum.InCookingProcess);
                this.cookingSimulator.CheckNewOrders();
                this.UpdateView = true;
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no controlado");
            }
        }

        private void btnRejectOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetSelectedOrder();

                new OrderService().ChangeOrderStatus(order.Id, StatusCodeEnum.Rejected);
                this.UpdateView = true;
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no controlado");
            }
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetSelectedOrder();

                new OrderService().ChangeOrderStatus(order.Id, StatusCodeEnum.SucessfullyDelivered);
                this.UpdateView = true;
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error no controlado");
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedCellHandle();
        }

        private void SelectedCellHandle()
        {
            if (dgvOrders.SelectedCells.Count == 0)
                return;

            var selectedRow = dgvOrders.SelectedCells[0].RowIndex;
            var order = (Order)(dgvOrders.Rows[selectedRow].DataBoundItem);
            this.ButtonConfiguration(order);
        }

        private Order GetSelectedOrder()
        {
            this.ValidateSelectedCell();

            var selectedRow = dgvOrders.SelectedCells[0].RowIndex;
            return (Order)(dgvOrders.Rows[selectedRow].DataBoundItem);
        }

        private void ValidateSelectedCell()
        {
            if (dgvOrders.SelectedCells.Count == 0)
                throw new CustomException("No hay ordenes seleccionadas para aceptar");
        }

        void ICookingNotifier.Update()
        {
            this.UpdateView = true;
        }

        private void FillDatagrid()
        {
            var sessionUser = Session.GetInstance().AdminUser;

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = new OrderService().GetByUserKeyOwner(sessionUser.Key);
            this.colorDgv();
        }

        private void ButtonConfiguration(Order order)
        {
            if (order.Status.Code == (int)StatusCodeEnum.InConfirmationProcess)
            {
                btnAcceptOrder.Enabled = true;
                btnRejectOrder.Enabled = true;
                btnDeliver.Enabled = false;
            }
            else if (order.Status.Code == (int)StatusCodeEnum.WaitingForDeliver)
            {
                btnAcceptOrder.Enabled = false;
                btnRejectOrder.Enabled = false;
                btnDeliver.Enabled = true;
            }
            else if (order.Status.Code == (int)StatusCodeEnum.SucessfullyDelivered)
            {
                btnAcceptOrder.Enabled = false;
                btnRejectOrder.Enabled = false;
                btnDeliver.Enabled = false;
            }
            else
            {
                btnAcceptOrder.Enabled = false;
                btnRejectOrder.Enabled = false;
                btnDeliver.Enabled = false;
            }
        }

        private void colorDgv()
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                var order = (Order)row.DataBoundItem;

                if (order.Status.Id == (int)StatusCodeEnum.InConfirmationProcess)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                if (order.Status.Id == (int)StatusCodeEnum.InCookingProcess)
                {
                    row.DefaultCellStyle.BackColor = Color.Gray;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (order.Status.Id == (int)StatusCodeEnum.WaitingForDeliver)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

                if (order.Status.Id == (int)StatusCodeEnum.SucessfullyDelivered)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.UpdateView)
            {
                this.FillDatagrid();
                this.UpdateView = false;
            }
        }
    }
}
