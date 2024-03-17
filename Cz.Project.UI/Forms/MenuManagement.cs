using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class MenuManagement : Form
    {
        public MenuManagement()
        {
            InitializeComponent();
        }

        private void MenuManagement_Load(object sender, EventArgs e)
        {
            this.numDishPrice.Maximum = int.MaxValue;
            this.numDishPrice.Minimum = 0;

            this.numSectionPosition.Maximum = int.MaxValue;
            this.numSectionPosition.Minimum = 1;

            this.lblTableQuantity.Text = "0";

            this.cmbFoodPointName.DataSource = new FoodPointService().GetByUserKey(Session.GetInstance().AdminUser.Key);

            this.ProcessFoodPointSelection();
        }

        private void cmbFoodPointName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFoodPointSelection();
        }

        private void cmbFoodPointName_KeyUp(object sender, KeyEventArgs e)
        {
            this.ProcessFoodPointSelection();
        }

        private void cmbMenuName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessMenuSelection();
        }

        private void cmbMenuName_KeyUp(object sender, KeyEventArgs e)
        {
            this.ProcessMenuSelection();
        }

        private void cmbSectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessSectionSelection();
        }

        private void cmbSectionName_KeyUp(object sender, KeyEventArgs e)
        {
            this.ProcessSectionSelection();
        }

        private void cmbDishName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessDishSelection();
        }

        private void cmbDishName_KeyUp(object sender, KeyEventArgs e)
        {
            this.ProcessDishSelection();
        }

        private void ProcessFoodPointSelection()
        {
            try
            {
                if (this.cmbFoodPointName.SelectedItem == null)
                {
                    this.cmbMenuName.DataSource = null;
                    this.cmbSectionName.DataSource = null;
                    this.numSectionPosition.Value = 1;
                    this.cmbDishName.DataSource = null;
                    this.numDishPrice.Value = 0;

                    this.btnAddFoodPoint.Enabled = true;
                    this.btnAddTable.Enabled = false;
                    this.btnDeleteTable.Enabled = false;
                    this.lblTableQuantity.Text = "0";

                    this.grpMenu.Enabled = false;

                    return;
                }

                var foodPoint = (FoodPoint)this.cmbFoodPointName.SelectedItem;
                this.btnAddFoodPoint.Enabled = false;
                this.btnAddTable.Enabled = true;

                if (foodPoint.Tables.Count != 0)
                    this.btnDeleteTable.Enabled = true;

                this.grpMenu.Enabled = true;
                this.lblTableQuantity.Text = foodPoint.Tables.Count.ToString();

                this.cmbMenuName.DataSource = new MenuService().GetByFoodPointId(foodPoint.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ProcessMenuSelection();
            }
        }

        private void ProcessMenuSelection()
        {
            try
            {
                if (this.cmbMenuName.SelectedItem == null)
                {
                    this.cmbSectionName.DataSource = null;
                    this.numSectionPosition.Value = 1;
                    this.cmbDishName.DataSource = null;
                    this.numDishPrice.Value = 0;

                    this.btnAddMenu.Enabled = true;
                    this.btnDeleteMenu.Enabled = false;
                    this.grpSection.Enabled = false;


                    return;
                }

                var menu = (Menu)this.cmbMenuName.SelectedItem;
                this.btnAddMenu.Enabled = false;
                this.btnDeleteMenu.Enabled = true;
                this.grpSection.Enabled = true;

                this.cmbSectionName.DataSource = new SectionService().GetByMenuId(menu.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ProcessSectionSelection();
            }
        }

        private void ProcessSectionSelection()
        {
            try
            {
                if (this.cmbSectionName.SelectedItem == null)
                {
                    this.cmbDishName.DataSource = null;
                    this.numDishPrice.Value = 0;

                    this.btnAddSection.Enabled = true;
                    this.btnDeleteSection.Enabled = false;
                    this.grpDish.Enabled = false;
                    return;
                }

                var section = (Section)this.cmbSectionName.SelectedItem;

                this.btnAddSection.Enabled = false;
                this.btnDeleteSection.Enabled = true;
                this.grpDish.Enabled = true;

                this.numSectionPosition.Value = section.Position;
                this.cmbDishName.DataSource = new DishService().GetBySection(section.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ProcessDishSelection();
            }
        }

        private void ProcessDishSelection()
        {
            try
            {
                if (this.cmbDishName.SelectedItem == null)
                {
                    this.btnAddDish.Enabled = true;
                    this.btnDeleteDish.Enabled = false;
                    return;
                }

                var dish = (Dish)this.cmbDishName.SelectedItem;
                this.btnAddDish.Enabled = false;
                this.btnDeleteDish.Enabled = true;

                this.numDishPrice.Value = (decimal)dish.Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddFoodPoint_Click(object sender, EventArgs e)
        {
            try
            {
                var fs = new FoodPointService();
                fs.Add(cmbFoodPointName.Text, Session.GetInstance().AdminUser.Key);

                this.RefresView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                var ts = new TableService();
                ts.Add(new Table()
                {
                    FoodPointId = ((FoodPoint)this.cmbFoodPointName.SelectedItem).Id
                });

                var response = MessageBox.Show("Se agrego correctamente una nueva mesa. ¿Desea refrescar la vista?", "Nuevos datos", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    this.RefresView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var ms = new MenuService();
                ms.CreateDefaultMenu(((FoodPoint)cmbFoodPointName.SelectedItem).Id);

                var response = MessageBox.Show("Se agrego correctamente un nuevo menu. ¿Desea refrescar la vista?", "Nuevos datos", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    this.RefresView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefresView()
        {
            this.cmbFoodPointName.DataSource = new FoodPointService().GetByUserKey(Session.GetInstance().AdminUser.Key);
            ProcessFoodPointSelection();
        }
    }
}
