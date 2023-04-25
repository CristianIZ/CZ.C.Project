using System;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class MainFormAlternative : Form
    {
        public Form ActiveForm;

        public MainFormAlternative()
        {
            InitializeComponent();
        }

        private void MainFormAlternative_Load(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
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
    }
}
