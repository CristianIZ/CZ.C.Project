using Cz.Project.Abstraction;
using Cz.Project.Abstraction.Enums;
using Cz.Project.Abstraction.Translation_Observer;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
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
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            TranslationHelper.Translation.Attach(this);

            btnHome.Tag = new WordDto() { Code = (int)MainFormWordsEnum.Home };
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

        public void Update(LanguajesCodeEnum languaje)
        {
            var translationService = new TranslationService();
            var words = translationService.GetWords(languaje);

            btnHome.Text = $"\t{words.Where(w => w.Code == (int)MainFormWordsEnum.Home).Select(w => w.Text).First()}";
        }
    }
}
