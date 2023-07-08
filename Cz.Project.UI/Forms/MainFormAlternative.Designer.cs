namespace Cz.Project.UI.Forms
{
    partial class MainFormAlternative
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormAlternative));
            panel1 = new System.Windows.Forms.Panel();
            btnConfig = new System.Windows.Forms.Button();
            btnAssignLicenses = new System.Windows.Forms.Button();
            btnLicenses = new System.Windows.Forms.Button();
            btnUsers = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            lblUserName = new System.Windows.Forms.Label();
            btnLogOut = new System.Windows.Forms.Button();
            pnlFormReplace = new System.Windows.Forms.Panel();
            btnAddLanguaje = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnAddLanguaje);
            panel1.Controls.Add(btnConfig);
            panel1.Controls.Add(btnAssignLicenses);
            panel1.Controls.Add(btnLicenses);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(220, 561);
            panel1.TabIndex = 0;
            // 
            // btnConfig
            // 
            btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfig.ForeColor = System.Drawing.Color.Gainsboro;
            btnConfig.Image = (System.Drawing.Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfig.Location = new System.Drawing.Point(0, 320);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnConfig.Size = new System.Drawing.Size(220, 60);
            btnConfig.TabIndex = 7;
            btnConfig.Text = "     Config";
            btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnAssignLicenses
            // 
            btnAssignLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            btnAssignLicenses.FlatAppearance.BorderSize = 0;
            btnAssignLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAssignLicenses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAssignLicenses.ForeColor = System.Drawing.Color.Gainsboro;
            btnAssignLicenses.Image = (System.Drawing.Image)resources.GetObject("btnAssignLicenses.Image");
            btnAssignLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAssignLicenses.Location = new System.Drawing.Point(0, 260);
            btnAssignLicenses.Name = "btnAssignLicenses";
            btnAssignLicenses.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnAssignLicenses.Size = new System.Drawing.Size(220, 60);
            btnAssignLicenses.TabIndex = 5;
            btnAssignLicenses.Text = "     Asignar         Permisos";
            btnAssignLicenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAssignLicenses.UseVisualStyleBackColor = true;
            btnAssignLicenses.Click += btnAssignLicenses_Click;
            // 
            // btnLicenses
            // 
            btnLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            btnLicenses.FlatAppearance.BorderSize = 0;
            btnLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLicenses.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLicenses.ForeColor = System.Drawing.Color.Gainsboro;
            btnLicenses.Image = (System.Drawing.Image)resources.GetObject("btnLicenses.Image");
            btnLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLicenses.Location = new System.Drawing.Point(0, 200);
            btnLicenses.Name = "btnLicenses";
            btnLicenses.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnLicenses.Size = new System.Drawing.Size(220, 60);
            btnLicenses.TabIndex = 4;
            btnLicenses.Text = "     Permisos";
            btnLicenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLicenses.UseVisualStyleBackColor = true;
            btnLicenses.Click += btnLicenses_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            btnUsers.Image = (System.Drawing.Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsers.Location = new System.Drawing.Point(0, 140);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnUsers.Size = new System.Drawing.Size(220, 60);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "     Usuarios";
            btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(0, 80);
            btnHome.Name = "btnHome";
            btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnHome.Size = new System.Drawing.Size(220, 60);
            btnHome.TabIndex = 2;
            btnHome.Text = "   Principal";
            btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(220, 80);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(50, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Restapp";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            lblTitle.Location = new System.Drawing.Point(6, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(50, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblTitle);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(564, 80);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblUserName);
            panel4.Controls.Add(btnLogOut);
            panel4.Dock = System.Windows.Forms.DockStyle.Right;
            panel4.Location = new System.Drawing.Point(364, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(200, 80);
            panel4.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUserName.ForeColor = System.Drawing.Color.Gainsboro;
            lblUserName.Location = new System.Drawing.Point(57, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(104, 25);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = System.Drawing.Color.Teal;
            btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogOut.Location = new System.Drawing.Point(0, 45);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnLogOut.Size = new System.Drawing.Size(200, 35);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Cerrar sesion";
            btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pnlFormReplace
            // 
            pnlFormReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFormReplace.Location = new System.Drawing.Point(220, 80);
            pnlFormReplace.Name = "pnlFormReplace";
            pnlFormReplace.Size = new System.Drawing.Size(564, 481);
            pnlFormReplace.TabIndex = 2;
            // 
            // btnAddLanguaje
            // 
            btnAddLanguaje.Dock = System.Windows.Forms.DockStyle.Top;
            btnAddLanguaje.FlatAppearance.BorderSize = 0;
            btnAddLanguaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddLanguaje.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddLanguaje.ForeColor = System.Drawing.Color.Gainsboro;
            btnAddLanguaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddLanguaje.Location = new System.Drawing.Point(0, 380);
            btnAddLanguaje.Name = "btnAddLanguaje";
            btnAddLanguaje.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            btnAddLanguaje.Size = new System.Drawing.Size(220, 60);
            btnAddLanguaje.TabIndex = 6;
            btnAddLanguaje.Text = "     Nuevo Lenguaje";
            btnAddLanguaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddLanguaje.UseVisualStyleBackColor = true;
            btnAddLanguaje.Click += btnAddLanguaje_Click;
            // 
            // MainFormAlternative
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(pnlFormReplace);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "MainFormAlternative";
            Text = "Restapp";
            Load += MainFormAlternative_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnAssignLicenses;
        private System.Windows.Forms.Button btnLicenses;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFormReplace;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnAddLanguaje;
    }
}