namespace Cz.Project.UI.Forms
{
    partial class MakeOrderForm
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
            treeViewMenu = new System.Windows.Forms.TreeView();
            label1 = new System.Windows.Forms.Label();
            btnGenerateOrder = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cmbTables = new System.Windows.Forms.ComboBox();
            qrPic = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblTotalAmount = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lblFoodPointName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)qrPic).BeginInit();
            SuspendLayout();
            // 
            // treeViewMenu
            // 
            treeViewMenu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeViewMenu.Location = new System.Drawing.Point(12, 177);
            treeViewMenu.Name = "treeViewMenu";
            treeViewMenu.Size = new System.Drawing.Size(526, 398);
            treeViewMenu.TabIndex = 0;
            treeViewMenu.AfterCheck += treeViewMenu_AfterCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 159);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // btnGenerateOrder
            // 
            btnGenerateOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGenerateOrder.Location = new System.Drawing.Point(392, 622);
            btnGenerateOrder.Name = "btnGenerateOrder";
            btnGenerateOrder.Size = new System.Drawing.Size(146, 23);
            btnGenerateOrder.TabIndex = 2;
            btnGenerateOrder.Text = "Realizar pedido";
            btnGenerateOrder.UseVisualStyleBackColor = true;
            btnGenerateOrder.Click += btnGenerateOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "Seleccionar Mesa";
            // 
            // cmbTables
            // 
            cmbTables.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new System.Drawing.Point(12, 27);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new System.Drawing.Size(526, 23);
            cmbTables.TabIndex = 4;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // qrPic
            // 
            qrPic.Location = new System.Drawing.Point(12, 56);
            qrPic.Name = "qrPic";
            qrPic.Size = new System.Drawing.Size(100, 100);
            qrPic.TabIndex = 5;
            qrPic.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 600);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Estado:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(63, 600);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(38, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label4";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 578);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Costo:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new System.Drawing.Point(63, 578);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new System.Drawing.Size(38, 15);
            lblTotalAmount.TabIndex = 9;
            lblTotalAmount.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(118, 56);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 15);
            label7.TabIndex = 10;
            label7.Text = "Local:";
            // 
            // lblFoodPointName
            // 
            lblFoodPointName.AutoSize = true;
            lblFoodPointName.Location = new System.Drawing.Point(169, 56);
            lblFoodPointName.Name = "lblFoodPointName";
            lblFoodPointName.Size = new System.Drawing.Size(38, 15);
            lblFoodPointName.TabIndex = 12;
            lblFoodPointName.Text = "label8";
            // 
            // MakeOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(551, 657);
            Controls.Add(lblFoodPointName);
            Controls.Add(label7);
            Controls.Add(lblTotalAmount);
            Controls.Add(label5);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(qrPic);
            Controls.Add(cmbTables);
            Controls.Add(label2);
            Controls.Add(btnGenerateOrder);
            Controls.Add(label1);
            Controls.Add(treeViewMenu);
            Name = "MakeOrderForm";
            Text = "MakeOrderForm";
            Load += MakeOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)qrPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.PictureBox qrPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFoodPointName;
    }
}