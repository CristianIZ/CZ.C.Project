using Cz.Project.Dto;
using Cz.Project.Services;
using Cz.Project.Services.UserSession;
using Cz.Project.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
            var userService = new UserService();

            foreach (var item in userService.GetAll())
            {
                cmbUsers.Items.Add(item);
            }

            cmbUsers.SelectedIndex = 0;
        }

        private void treeLicenses_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeLicenses.Enabled = false;
            this.treeLicenses.AfterCheck -= this.treeLicenses_AfterCheck;
            TreeViewHelper.CheckNodeBeheavor(e);
            this.treeLicenses.AfterCheck += new TreeViewEventHandler(this.treeLicenses_AfterCheck);
            treeLicenses.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                Licenses = TreeViewHelper.GetLeafs(this.treeLicenses.Nodes, new List<Abstraction.LicenseDto>())
            };

            var licenseService = new AdminUserLicenseService();
            licenseService.SetPermissions(adminLicenses);

            treeLicenses.Enabled = true;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null)
                return;
            
            var selectedUser = (AdminUserDto)cmbUsers.SelectedItem;
            var adminUser = new UserService().GetByKeyDto(selectedUser.Key);
            var adminUserLicenses = new AdminUserLicenseService().GetLicensesByUser(adminUser.Key);

            TreeViewHelper.FillLicenseTreeView(new LicenseService().GetLicenseTree(), treeLicenses, adminUserLicenses?.Licenses);
        }
    }
}
