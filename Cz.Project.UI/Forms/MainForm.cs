using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Translation_Observer;
using Cz.Project.GenericServices;
using System;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class MainForm : Form, ITranslationNotifier
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UIOptions(false);

            // ((ToolStripDropDownItem)this.menuStrip1.Items[1]).DropDown.Items;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.response.LoginSuccessfully)
            {
                UIOptions(true);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adminUsersForm = new AdminUsersForm();
            var result = adminUsersForm.ShowDialog();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var licenseForm = new LicenseForm();
            var result = licenseForm.ShowDialog();
        }

        public void UIOptions(bool enable)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.Text != "Login")
                    item.Enabled = enable;
            }
        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userLicense = new UserLicenseForm();
            userLicense.ShowDialog();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var translationService = new TranslationService();
            translationService.ChangeLenguaje(LanguajesCodeEnum.english);
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var translationService = new TranslationService();
            translationService.ChangeLenguaje(LanguajesCodeEnum.spanish);
        }

        public void Update(LanguajesCodeEnum languaje)
        {

        }
    }
}
