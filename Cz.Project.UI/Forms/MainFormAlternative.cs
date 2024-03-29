﻿using Cz.Project.Abstraction;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Translation_Observer;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
using Cz.Project.GenericServices.UserSession;
using Cz.Project.UI.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class MainFormAlternative : Form, ITranslationNotifier
    {
        public Form ActiveForm;
        public MainFormAlternative()
        {
            InitializeComponent();
        }

        private void MainFormAlternative_Load(object sender, EventArgs e)
        {
            try
            {
                // Check created database
                if (!TestDatabaseHelper.IsDatabaseCreated())
                {
                    TestDatabaseHelper.CreateDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error con la conexion a la base de datos");
                this.Close();
            }

            ForceLogin();

            TranslationHelper.Translation.Attach(this);
            btnHome.Tag = new WordDto() { Code = (int)MainFormWordsEnum.Home };
            btnUsers.Tag = new WordDto() { Code = (int)MainFormWordsEnum.UserManagement };
            // btnLicenses.Tag = new WordDto() { Code = (int)MainFormWordsEnum.License };
            btnAssignLicenses.Tag = new WordDto() { Code = (int)MainFormWordsEnum.LicenseAssignment };
            btnConfig.Tag = new WordDto() { Code = (int)MainFormWordsEnum.Config };

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminUsersForm());
        }

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LicenseForm());
        }

        private void btnAssignLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserLicenseForm());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConfigForm());
        }

        private void btnAddLanguaje_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ABMLanguajeForm());
        }

        private void btnFamilyLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FamilyLicenseForm());
        }

        private void btnBitacoraAndLogs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BitacoraAndLogsForm());
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MakeOrderForm());
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderManagementForm());
        }

        private void btnOrderMonitor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderMonitorForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.LogOut();
            lblUserName.Text = "UserName";
            this.Hide();

            ForceLogin();
        }

        private void ForceLogin()
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (Session.GetInstance().AdminUser == null)
            {
                this.Close();
            }
            else
            {
                lblUserName.Text = Session.GetInstance().AdminUser.Name;
                this.Show();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();

            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlFormReplace.Controls.Add(childForm);
            this.pnlFormReplace.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        public void Update(LanguajeDto languaje)
        {
            var translationService = new TranslationService();
            var words = translationService.GetWords(languaje);

            var identation = "    ";
            btnHome.Text = $"{identation}{words.Where(w => w.Code == (int)MainFormWordsEnum.Home).Select(w => w.Text).First()}";
            btnUsers.Text = $"{identation}{words.Where(w => w.Code == (int)MainFormWordsEnum.UserManagement).Select(w => w.Text).First()}";
            // btnLicenses.Text = $"{identation}{words.Where(w => w.Code == (int)MainFormWordsEnum.License).Select(w => w.Text).First()}";
            btnAssignLicenses.Text = $"{identation}{words.Where(w => w.Code == (int)MainFormWordsEnum.LicenseAssignment).Select(w => w.Text).First()}";
            btnConfig.Text = $"{identation}{words.Where(w => w.Code == (int)MainFormWordsEnum.Config).Select(w => w.Text).First()}";
        }
    }
}
