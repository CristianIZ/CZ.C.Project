namespace Cz.SecurityColumGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheckRowIntegrity = new Button();
            btnCheckTableIntegrity = new Button();
            FixTableIntegrity = new Button();
            txtPassword = new TextBox();
            txtEncriptedPassword = new TextBox();
            btnEncrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCopyEncriptedPassword = new Button();
            SuspendLayout();
            // 
            // btnCheckRowIntegrity
            // 
            btnCheckRowIntegrity.Location = new Point(28, 88);
            btnCheckRowIntegrity.Name = "btnCheckRowIntegrity";
            btnCheckRowIntegrity.Size = new Size(162, 23);
            btnCheckRowIntegrity.TabIndex = 0;
            btnCheckRowIntegrity.Text = "Check rows integrity";
            btnCheckRowIntegrity.UseVisualStyleBackColor = true;
            btnCheckRowIntegrity.Click += btnCheckRowIntegrity_Click;
            // 
            // btnCheckTableIntegrity
            // 
            btnCheckTableIntegrity.Location = new Point(28, 117);
            btnCheckTableIntegrity.Name = "btnCheckTableIntegrity";
            btnCheckTableIntegrity.Size = new Size(162, 23);
            btnCheckTableIntegrity.TabIndex = 1;
            btnCheckTableIntegrity.Text = "Check table integrity";
            btnCheckTableIntegrity.UseVisualStyleBackColor = true;
            btnCheckTableIntegrity.Click += btnCheckTableIntegrity_Click;
            // 
            // FixTableIntegrity
            // 
            FixTableIntegrity.Location = new Point(28, 146);
            FixTableIntegrity.Name = "FixTableIntegrity";
            FixTableIntegrity.Size = new Size(162, 23);
            FixTableIntegrity.TabIndex = 2;
            FixTableIntegrity.Text = "Fix table Integrity";
            FixTableIntegrity.UseVisualStyleBackColor = true;
            FixTableIntegrity.Click += FixTableIntegrity_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtEncriptedPassword
            // 
            txtEncriptedPassword.Location = new Point(147, 41);
            txtEncriptedPassword.Name = "txtEncriptedPassword";
            txtEncriptedPassword.Size = new Size(183, 23);
            txtEncriptedPassword.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(336, 41);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(111, 23);
            btnEncrypt.TabIndex = 5;
            btnEncrypt.Text = "Generate";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 7;
            label2.Text = "Encrypted Password";
            // 
            // btnCopyEncriptedPassword
            // 
            btnCopyEncriptedPassword.Location = new Point(453, 41);
            btnCopyEncriptedPassword.Name = "btnCopyEncriptedPassword";
            btnCopyEncriptedPassword.Size = new Size(49, 23);
            btnCopyEncriptedPassword.TabIndex = 8;
            btnCopyEncriptedPassword.Text = "Copy";
            btnCopyEncriptedPassword.UseVisualStyleBackColor = true;
            btnCopyEncriptedPassword.Click += btnCopyEncriptedPassword_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 182);
            Controls.Add(btnCopyEncriptedPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncrypt);
            Controls.Add(txtEncriptedPassword);
            Controls.Add(txtPassword);
            Controls.Add(FixTableIntegrity);
            Controls.Add(btnCheckTableIntegrity);
            Controls.Add(btnCheckRowIntegrity);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckRowIntegrity;
        private Button btnCheckTableIntegrity;
        private Button FixTableIntegrity;
        private TextBox txtPassword;
        private TextBox txtEncriptedPassword;
        private Button btnEncrypt;
        private Label label1;
        private Label label2;
        private Button btnCopyEncriptedPassword;
    }
}
