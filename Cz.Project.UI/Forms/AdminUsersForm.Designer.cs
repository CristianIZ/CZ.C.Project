namespace Cz.Project.UI.Forms
{
    partial class AdminUsersForm
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
            lstUsers = new System.Windows.Forms.ListBox();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lstHistoricalInformation = new System.Windows.Forms.ListBox();
            label4 = new System.Windows.Forms.Label();
            btnRecover = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new System.Drawing.Point(12, 130);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new System.Drawing.Size(421, 409);
            lstUsers.TabIndex = 0;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.Location = new System.Drawing.Point(12, 545);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(192, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnEdit.Location = new System.Drawing.Point(210, 545);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(153, 31);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnDelete.Location = new System.Drawing.Point(369, 545);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(64, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtName.Location = new System.Drawing.Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(747, 23);
            txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPassword.Location = new System.Drawing.Point(12, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(747, 23);
            txtPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Usuarios";
            // 
            // lstHistoricalInformation
            // 
            lstHistoricalInformation.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lstHistoricalInformation.FormattingEnabled = true;
            lstHistoricalInformation.ItemHeight = 15;
            lstHistoricalInformation.Location = new System.Drawing.Point(439, 130);
            lstHistoricalInformation.Name = "lstHistoricalInformation";
            lstHistoricalInformation.Size = new System.Drawing.Size(320, 409);
            lstHistoricalInformation.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(439, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Historico";
            // 
            // btnRecover
            // 
            btnRecover.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRecover.Location = new System.Drawing.Point(670, 545);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new System.Drawing.Size(89, 31);
            btnRecover.TabIndex = 11;
            btnRecover.Text = "Recuperar";
            btnRecover.UseVisualStyleBackColor = true;
            btnRecover.Click += btnRecover_Click;
            // 
            // AdminUsersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(774, 599);
            Controls.Add(btnRecover);
            Controls.Add(label4);
            Controls.Add(lstHistoricalInformation);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lstUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(btnEdit);
            Name = "AdminUsersForm";
            Text = "Administracion de usuarios";
            Load += AdminUsersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstHistoricalInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRecover;
    }
}