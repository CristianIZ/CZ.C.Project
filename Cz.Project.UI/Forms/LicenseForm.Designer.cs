namespace Cz.Project.UI.Forms
{
    partial class LicenseForm
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
            licensesTreeView = new System.Windows.Forms.TreeView();
            txtLicenseName = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSaveChanges = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // licensesTreeView
            // 
            licensesTreeView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            licensesTreeView.Location = new System.Drawing.Point(12, 35);
            licensesTreeView.Name = "licensesTreeView";
            licensesTreeView.Size = new System.Drawing.Size(467, 236);
            licensesTreeView.TabIndex = 0;
            // 
            // txtLicenseName
            // 
            txtLicenseName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLicenseName.Location = new System.Drawing.Point(113, 6);
            txtLicenseName.Name = "txtLicenseName";
            txtLicenseName.Size = new System.Drawing.Size(248, 23);
            txtLicenseName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.Location = new System.Drawing.Point(367, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Agregar Permiso";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnEdit.Location = new System.Drawing.Point(167, 277);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(153, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDelete.Location = new System.Drawing.Point(12, 277);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(149, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSaveChanges.Location = new System.Drawing.Point(326, 277);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new System.Drawing.Size(153, 30);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Guardar Cambios";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // LicenseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(488, 321);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtLicenseName);
            Controls.Add(licensesTreeView);
            Name = "LicenseForm";
            Text = "Licencias";
            Load += LicenseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView licensesTreeView;
        private System.Windows.Forms.TextBox txtLicenseName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}