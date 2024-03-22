namespace Cz.Project.UI.Forms
{
    partial class MenuManagement
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
            btnAddFoodPoint = new System.Windows.Forms.Button();
            cmbFoodPointName = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmbMenuName = new System.Windows.Forms.ComboBox();
            cmbDishName = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            btnAddTable = new System.Windows.Forms.Button();
            btnDeleteTable = new System.Windows.Forms.Button();
            lblTableQuantity = new System.Windows.Forms.Label();
            btnAddMenu = new System.Windows.Forms.Button();
            btnAddDish = new System.Windows.Forms.Button();
            numDishPrice = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            grpLocal = new System.Windows.Forms.GroupBox();
            grpMenu = new System.Windows.Forms.GroupBox();
            btnDeleteMenu = new System.Windows.Forms.Button();
            btnDeleteSection = new System.Windows.Forms.Button();
            btnAddSection = new System.Windows.Forms.Button();
            cmbSectionName = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            grpDish = new System.Windows.Forms.GroupBox();
            btnDeleteDish = new System.Windows.Forms.Button();
            grpSection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)numDishPrice).BeginInit();
            grpLocal.SuspendLayout();
            grpMenu.SuspendLayout();
            grpDish.SuspendLayout();
            grpSection.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddFoodPoint
            // 
            btnAddFoodPoint.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddFoodPoint.Location = new System.Drawing.Point(364, 22);
            btnAddFoodPoint.Name = "btnAddFoodPoint";
            btnAddFoodPoint.Size = new System.Drawing.Size(82, 23);
            btnAddFoodPoint.TabIndex = 5;
            btnAddFoodPoint.Text = "Agregar";
            btnAddFoodPoint.UseVisualStyleBackColor = true;
            btnAddFoodPoint.Click += btnAddFoodPoint_Click;
            // 
            // cmbFoodPointName
            // 
            cmbFoodPointName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbFoodPointName.FormattingEnabled = true;
            cmbFoodPointName.Location = new System.Drawing.Point(63, 22);
            cmbFoodPointName.Name = "cmbFoodPointName";
            cmbFoodPointName.Size = new System.Drawing.Size(295, 23);
            cmbFoodPointName.TabIndex = 4;
            cmbFoodPointName.SelectedIndexChanged += cmbFoodPointName_SelectedIndexChanged;
            cmbFoodPointName.KeyUp += cmbFoodPointName_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // cmbMenuName
            // 
            cmbMenuName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbMenuName.FormattingEnabled = true;
            cmbMenuName.Location = new System.Drawing.Point(63, 17);
            cmbMenuName.Name = "cmbMenuName";
            cmbMenuName.Size = new System.Drawing.Size(383, 23);
            cmbMenuName.TabIndex = 8;
            cmbMenuName.SelectedIndexChanged += cmbMenuName_SelectedIndexChanged;
            cmbMenuName.KeyUp += cmbMenuName_KeyUp;
            // 
            // cmbDishName
            // 
            cmbDishName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDishName.FormattingEnabled = true;
            cmbDishName.Location = new System.Drawing.Point(63, 22);
            cmbDishName.Name = "cmbDishName";
            cmbDishName.Size = new System.Drawing.Size(383, 23);
            cmbDishName.TabIndex = 9;
            cmbDishName.SelectedIndexChanged += cmbDishName_SelectedIndexChanged;
            cmbDishName.KeyUp += cmbDishName_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 63);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 11;
            label4.Text = "Mesas";
            // 
            // btnAddTable
            // 
            btnAddTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddTable.Location = new System.Drawing.Point(216, 59);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new System.Drawing.Size(112, 23);
            btnAddTable.TabIndex = 12;
            btnAddTable.Text = "Agregar mesa";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteTable.Location = new System.Drawing.Point(334, 59);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new System.Drawing.Size(112, 23);
            btnDeleteTable.TabIndex = 13;
            btnDeleteTable.Text = "Eliminar mesa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // lblTableQuantity
            // 
            lblTableQuantity.AutoSize = true;
            lblTableQuantity.Location = new System.Drawing.Point(72, 63);
            lblTableQuantity.Name = "lblTableQuantity";
            lblTableQuantity.Size = new System.Drawing.Size(25, 15);
            lblTableQuantity.TabIndex = 14;
            lblTableQuantity.Text = "000";
            // 
            // btnAddMenu
            // 
            btnAddMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddMenu.Location = new System.Drawing.Point(216, 54);
            btnAddMenu.Name = "btnAddMenu";
            btnAddMenu.Size = new System.Drawing.Size(112, 23);
            btnAddMenu.TabIndex = 15;
            btnAddMenu.Text = "Agregar";
            btnAddMenu.UseVisualStyleBackColor = true;
            btnAddMenu.Click += btnAddMenu_Click;
            // 
            // btnAddDish
            // 
            btnAddDish.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddDish.Location = new System.Drawing.Point(216, 59);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new System.Drawing.Size(112, 23);
            btnAddDish.TabIndex = 16;
            btnAddDish.Text = "Agregar";
            btnAddDish.UseVisualStyleBackColor = true;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // numDishPrice
            // 
            numDishPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numDishPrice.Location = new System.Drawing.Point(63, 59);
            numDishPrice.Name = "numDishPrice";
            numDishPrice.Size = new System.Drawing.Size(147, 23);
            numDishPrice.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 25);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 15);
            label6.TabIndex = 18;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 63);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 15);
            label7.TabIndex = 19;
            label7.Text = "Precio";
            // 
            // grpLocal
            // 
            grpLocal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpLocal.Controls.Add(label1);
            grpLocal.Controls.Add(cmbFoodPointName);
            grpLocal.Controls.Add(btnAddFoodPoint);
            grpLocal.Controls.Add(label4);
            grpLocal.Controls.Add(btnAddTable);
            grpLocal.Controls.Add(btnDeleteTable);
            grpLocal.Controls.Add(lblTableQuantity);
            grpLocal.Location = new System.Drawing.Point(12, 12);
            grpLocal.Name = "grpLocal";
            grpLocal.Size = new System.Drawing.Size(452, 106);
            grpLocal.TabIndex = 20;
            grpLocal.TabStop = false;
            grpLocal.Text = "Local";
            // 
            // grpMenu
            // 
            grpMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpMenu.Controls.Add(btnDeleteMenu);
            grpMenu.Controls.Add(label2);
            grpMenu.Controls.Add(cmbMenuName);
            grpMenu.Controls.Add(btnAddMenu);
            grpMenu.Location = new System.Drawing.Point(12, 124);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new System.Drawing.Size(452, 91);
            grpMenu.TabIndex = 21;
            grpMenu.TabStop = false;
            grpMenu.Text = "Menu";
            // 
            // btnDeleteMenu
            // 
            btnDeleteMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteMenu.Location = new System.Drawing.Point(334, 54);
            btnDeleteMenu.Name = "btnDeleteMenu";
            btnDeleteMenu.Size = new System.Drawing.Size(112, 23);
            btnDeleteMenu.TabIndex = 18;
            btnDeleteMenu.Text = "Eliminar";
            btnDeleteMenu.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteSection.Location = new System.Drawing.Point(334, 61);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Size = new System.Drawing.Size(112, 23);
            btnDeleteSection.TabIndex = 20;
            btnDeleteSection.Text = "Eliminar";
            btnDeleteSection.UseVisualStyleBackColor = true;
            btnDeleteSection.Click += btnDeleteSection_Click;
            // 
            // btnAddSection
            // 
            btnAddSection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnAddSection.Location = new System.Drawing.Point(216, 61);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new System.Drawing.Size(112, 23);
            btnAddSection.TabIndex = 19;
            btnAddSection.Text = "Agregar";
            btnAddSection.UseVisualStyleBackColor = true;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // cmbSectionName
            // 
            cmbSectionName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbSectionName.FormattingEnabled = true;
            cmbSectionName.Location = new System.Drawing.Point(63, 22);
            cmbSectionName.Name = "cmbSectionName";
            cmbSectionName.Size = new System.Drawing.Size(383, 23);
            cmbSectionName.TabIndex = 17;
            cmbSectionName.SelectedIndexChanged += cmbSectionName_SelectedIndexChanged;
            cmbSectionName.KeyUp += cmbSectionName_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 16;
            label3.Text = "Seccion";
            // 
            // grpDish
            // 
            grpDish.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpDish.Controls.Add(btnDeleteDish);
            grpDish.Controls.Add(label6);
            grpDish.Controls.Add(cmbDishName);
            grpDish.Controls.Add(btnAddDish);
            grpDish.Controls.Add(label7);
            grpDish.Controls.Add(numDishPrice);
            grpDish.Location = new System.Drawing.Point(12, 321);
            grpDish.Name = "grpDish";
            grpDish.Size = new System.Drawing.Size(452, 103);
            grpDish.TabIndex = 22;
            grpDish.TabStop = false;
            grpDish.Text = "Plato";
            // 
            // btnDeleteDish
            // 
            btnDeleteDish.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnDeleteDish.Location = new System.Drawing.Point(334, 59);
            btnDeleteDish.Name = "btnDeleteDish";
            btnDeleteDish.Size = new System.Drawing.Size(112, 23);
            btnDeleteDish.TabIndex = 20;
            btnDeleteDish.Text = "Eliminar";
            btnDeleteDish.UseVisualStyleBackColor = true;
            btnDeleteDish.Click += btnDeleteDish_Click;
            // 
            // grpSection
            // 
            grpSection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpSection.Controls.Add(cmbSectionName);
            grpSection.Controls.Add(label3);
            grpSection.Controls.Add(btnAddSection);
            grpSection.Controls.Add(btnDeleteSection);
            grpSection.Location = new System.Drawing.Point(12, 221);
            grpSection.Name = "grpSection";
            grpSection.Size = new System.Drawing.Size(452, 94);
            grpSection.TabIndex = 23;
            grpSection.TabStop = false;
            grpSection.Text = "Section";
            // 
            // MenuManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(473, 432);
            Controls.Add(grpSection);
            Controls.Add(grpDish);
            Controls.Add(grpMenu);
            Controls.Add(grpLocal);
            Name = "MenuManagement";
            Text = "Gestion de Menu";
            Load += MenuManagement_Load;
            ((System.ComponentModel.ISupportInitialize)numDishPrice).EndInit();
            grpLocal.ResumeLayout(false);
            grpLocal.PerformLayout();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpDish.ResumeLayout(false);
            grpDish.PerformLayout();
            grpSection.ResumeLayout(false);
            grpSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddFoodPoint;
        private System.Windows.Forms.ComboBox cmbFoodPointName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenuName;
        private System.Windows.Forms.ComboBox cmbDishName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.NumericUpDown numDishPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpLocal;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.ComboBox cmbSectionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDish;
        private System.Windows.Forms.Button btnDeleteSection;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Label lblTableQuantity;
    }
}