namespace Cz.SecurityColumGenerator
{
    public partial class Form1 : Form
    {
        private AdminUserIntegrity adminUserIntegrity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.adminUserIntegrity = new AdminUserIntegrity();
        }

        private void btnCheckRowIntegrity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.adminUserIntegrity.CheckAllRowsIntegrity(true));
        }

        private void btnCheckTableIntegrity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.adminUserIntegrity.CheckTableIntegrity());
        }

        private void FixTableIntegrity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.adminUserIntegrity.GenerateTableVerificationDigit());
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncriptedPassword.Text = this.adminUserIntegrity.EncryptPassword(txtPassword.Text);
        }

        private void btnCopyEncriptedPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEncriptedPassword.Text);
        }
    }
}
