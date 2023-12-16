using Cz.Project.Abstraction.License_Composite;
using Cz.Project.Dto;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class UserLicenseForm : Form
    {
        public UserLicenseForm()
        {
            InitializeComponent();
        }

        private void UserLicenseForm_Load(object sender, EventArgs e)
        {
            try
            {
                var userService = new UserService();
                var licenseService = new LicenseService();

                foreach (var item in userService.GetAll())
                {
                    cmbUsers.Items.Add(item);
                }

                foreach (var item in licenseService.GetFamilies())
                {
                    cmbFamily.Items.Add(item);
                }

                cmbFamily.SelectedItem = cmbFamily.Items[0];
                cmbUsers.SelectedItem = cmbUsers.Items[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeLicenses_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                #region Unsubscribe
                treeLicenses.Enabled = false;
                this.treeLicenses.AfterCheck -= this.treeLicenses_AfterCheck;
                #endregion

                TreeViewHelper.CheckNodeBeheavor(e);

                #region Subscribe back
                this.treeLicenses.AfterCheck += new TreeViewEventHandler(this.treeLicenses_AfterCheck);
                treeLicenses.Enabled = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                treeLicenses.Enabled = false;

                var session = Session.GetInstance();

                var adminLicenses = new AdminUserLicenseDto()
                {
                    AdminUser = new AdminUserDto()
                    {
                        Name = session.AdminUser.Name,
                        Key = session.AdminUser.Key,
                        Password = session.AdminUser.Password
                    },
                    Licenses = TreeViewHelper.GetCheckedLeafs(this.treeLicenses.Nodes, new List<Abstraction.LicenseDto>())
                };

                var licenseService = new AdminUserLicenseService();
                licenseService.SetPermissions(adminLicenses);

                treeLicenses.Enabled = true;

                MessageBox.Show("Guardado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillTreeView();
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillTreeView();
        }

        private void FillTreeView()
        {
            try
            {
                treeLicenses.Nodes.Clear();

                if (cmbUsers.SelectedItem == null)
                    return;

                var selectedUser = (AdminUserDto)cmbUsers.SelectedItem;
                var adminUser = new UserService().GetByKeyDto(selectedUser.Key);
                var adminUserLicenses = new AdminUserLicenseService().GetLicensesByUser(adminUser.Key);

                var familyDto = ((FamilyLicenseDto)cmbFamily.SelectedItem);

                TreeViewHelper.FillLicenseTreeView(new LicenseService().GetLicenseTree(familyDto.Id),
                                                   treeLicenses,
                                                   adminUserLicenses?.Licenses);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
