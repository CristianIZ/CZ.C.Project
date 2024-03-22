using Cz.Project.Domain.Business;
using Cz.Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using Cz.Project.UI.Helpers;
using System.Xml.Serialization;
using Cz.Project.Domain;
using System.Linq;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.GenericServices;
using Cz.Project.SQLContext.Enums;
using Cz.Project.Dto.Enums;

namespace Cz.Project.UI.Forms
{
    public partial class MakeOrderForm : Form
    {
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblFoodPointName.Text = "";
                lblTotalAmount.Text = "";
                lblStatus.Text = "";
                qrPic.SizeMode = PictureBoxSizeMode.StretchImage;
                treeViewMenu.CheckBoxes = true;

                var tables = new TableService().GetAllTables();

                foreach (var table in tables)
                {
                    cmbTables.Items.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado en el sistema");
            }
        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbTables.SelectedItem == null)
                    return;

                var table = (Table)this.cmbTables.SelectedItem;
                qrPic.Image = QrHelper.GenerateQr(table.QR.ToString(), 3);

                var foodPoint = new FoodPointService().GetById(table.FoodPointId);
                lblFoodPointName.Text = foodPoint.Name;

                foreach (var menu in foodPoint.Menu)
                {
                    this.PopulateTreeview(menu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado en el sistema");
            }
        }

        private void btnGenerateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedTable = (Table)this.cmbTables.SelectedItem;

                if (selectedTable == null)
                {
                    MessageBox.Show("Debe seleccionar una mesa para realizar un pedido");
                    return;
                }

                var dishes = this.GetSelectedDishes();

                if (dishes.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un elemento para pedir");
                    return;
                }

                var foodPoint = new FoodPointService().GetById(selectedTable.FoodPointId);
                var status = new StatusService().GetByCode(StatusCodeEnum.InConfirmationProcess);

                var order = new Order()
                {
                    AdminUsersId = new UserService().GetByKey(Session.GetInstance().AdminUser.Key).Id,
                    Amount = dishes.Sum(d => d.Price),
                    ChangeStatusDate = DateTime.Now,
                    FoodPointId = foodPoint.Id,
                    Status = status,
                    StatusId = status.Id,
                    StartDate = DateTime.Now
                };

                new OrderService().Add(order, dishes);
                lblStatus.Text = "In confirmation process";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado en el sistema");
            }
        }

        private IList<Dish> GetSelectedDishes()
        {
            IList<Dish> dishes = new List<Dish>();

            foreach (TreeNode node in treeViewMenu.Nodes)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (childNode.Checked)
                        dishes.Add((Dish)childNode.Tag);
                }
            }

            return dishes;
        }

        private void PopulateTreeview(Menu menu)
        {
            this.treeViewMenu.Nodes.Clear();
            this.lblTotalAmount.Text = string.Empty;

            foreach (var section in menu.Sections)
            {
                var node = new TreeNode();

                node.Text = section.Name;
                node.Tag = section;

                foreach (var dish in section.Dishes)
                {
                    var nodeChild = new TreeNode();

                    nodeChild.Text = dish.Name;
                    nodeChild.Tag = dish;

                    node.Nodes.Add(nodeChild);
                }

                treeViewMenu.Nodes.Add(node);
            }
        }

        private void treeViewMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var dishes = this.GetSelectedDishes();
            lblTotalAmount.Text = dishes.Sum(d => d.Price).ToString();
        }
    }
}
