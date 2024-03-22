namespace Cz.Project.UI.Forms
{
    partial class UserLicenseForm
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
            cmbUsers = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            treeLicenses = new System.Windows.Forms.TreeView();
            btnReset = new System.Windows.Forms.Button();
            cmbFamily = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new System.Drawing.Point(65, 12);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new System.Drawing.Size(279, 23);
            cmbUsers.TabIndex = 0;
            cmbUsers.SelectedIndexChanged += cmbUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 15);
            label2.TabIndex = 3;
            label2.Text = "Licencias disponibles";
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Location = new System.Drawing.Point(501, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(156, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // treeLicenses
            // 
            treeLicenses.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeLicenses.CheckBoxes = true;
            treeLicenses.Location = new System.Drawing.Point(12, 62);
            treeLicenses.Name = "treeLicenses";
            treeLicenses.Size = new System.Drawing.Size(645, 339);
            treeLicenses.TabIndex = 2;
            treeLicenses.AfterCheck += treeLicenses_AfterCheck;
            // 
            // btnReset
            // 
            btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnReset.Location = new System.Drawing.Point(12, 407);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(483, 34);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // cmbFamily
            // 
            cmbFamily.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbFamily.FormattingEnabled = true;
            cmbFamily.Location = new System.Drawing.Point(404, 12);
            cmbFamily.Name = "cmbFamily";
            cmbFamily.Size = new System.Drawing.Size(253, 23);
            cmbFamily.TabIndex = 10;
            cmbFamily.SelectedIndexChanged += cmbFamily_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(350, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Familia:";
            // 
            // UserLicenseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(669, 448);
            Controls.Add(label3);
            Controls.Add(cmbFamily);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(treeLicenses);
            Controls.Add(label1);
            Controls.Add(cmbUsers);
            Name = "UserLicenseForm";
            Text = "Licencias de usuarios";
            Load += UserLicenseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TreeView treeLicenses;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.Label label3;
    }
}