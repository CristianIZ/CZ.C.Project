using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.Services;
using Cz.Project.SQLContext;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class OrderMonitorForm : Form
    {
        public OrderMonitorForm()
        {
            InitializeComponent();

            lblAmount.Text = string.Empty;
            lblEndDate.Text = string.Empty;
            lblLocal.Text = string.Empty;
            lblStartDate.Text = string.Empty;
            lblStatus.Text = string.Empty;
        }

        private void OrderMonitorForm_Load(object sender, EventArgs e)
        {
            var adminUser = new AdminUsersContext().GetByKey(Session.GetInstance().AdminUser.Key);
            var orders = new OrderService().GetByUserId(adminUser.Id);

            lstOrderItems.DataSource = orders;
        }

        private void lstOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDishList();
        }

        private void SetDishList()
        {
            if (this.lstOrderItems.SelectedItem == null)
                return;

            var order = (Order)this.lstOrderItems.SelectedItem;

            lstDishes.DataSource = null;
            IList<Dish> dishes = new List<Dish>();

            foreach (var dishOrder in order.DishOrders)
            {
                var dish = new DishService().GetById(dishOrder.Id);
                dishes.Add(dish);
            }

            this.SetLabels(order);
            lstDishes.DataSource = dishes;
        }

        private void SetLabels(Order order)
        {
            lblAmount.Text = order.Amount.ToString();
            lblEndDate.Text = order.EndDate.ToString();
            lblStartDate.Text = order.StartDate.ToString();
            lblStatus.Text = order.Status.ToString();
            lblLocal.Text = new FoodPointService().GetById(order.FoodPointId).ToString();
        }
    }
}
