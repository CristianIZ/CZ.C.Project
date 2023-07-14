namespace Cz.Project.UI.Forms
{
    partial class FamilyLicenseForm
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
            treeviewNewFamily = new System.Windows.Forms.TreeView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lstLicenses = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // treeviewNewFamily
            // 
            treeviewNewFamily.Location = new System.Drawing.Point(305, 27);
            treeviewNewFamily.Name = "treeviewNewFamily";
            treeviewNewFamily.Size = new System.Drawing.Size(190, 289);
            treeviewNewFamily.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 15);
            label1.TabIndex = 3;
            label1.Text = "Licencias disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(305, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 15);
            label2.TabIndex = 4;
            label2.Text = "Nueva familia de licencias";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(208, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(91, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "-->";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(208, 139);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(91, 34);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "<--";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(171, 322);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(243, 23);
            txtName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(420, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 326);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre de la nueva familia";
            // 
            // lstLicenses
            // 
            lstLicenses.FormattingEnabled = true;
            lstLicenses.ItemHeight = 15;
            lstLicenses.Location = new System.Drawing.Point(12, 27);
            lstLicenses.Name = "lstLicenses";
            lstLicenses.Size = new System.Drawing.Size(190, 289);
            lstLicenses.TabIndex = 10;
            // 
            // FamilyLicenseForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(512, 371);
            Controls.Add(lstLicenses);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeviewNewFamily);
            Name = "FamilyLicenseForm";
            Text = "FamilyLicenseForm";
            Load += FamilyLicenseForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeviewNewFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLicenses;
    }
}