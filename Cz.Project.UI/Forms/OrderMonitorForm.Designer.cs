namespace Cz.Project.UI.Forms
{
    partial class OrderMonitorForm
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
            label1 = new System.Windows.Forms.Label();
            lstOrderItems = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblStartDate = new System.Windows.Forms.Label();
            lblEndDate = new System.Windows.Forms.Label();
            lblAmount = new System.Windows.Forms.Label();
            lblLocal = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            lstDishes = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Tus pedidos";
            // 
            // lstOrderItems
            // 
            lstOrderItems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lstOrderItems.FormattingEnabled = true;
            lstOrderItems.ItemHeight = 15;
            lstOrderItems.Location = new System.Drawing.Point(12, 27);
            lstOrderItems.Name = "lstOrderItems";
            lstOrderItems.Size = new System.Drawing.Size(175, 439);
            lstOrderItems.TabIndex = 1;
            lstOrderItems.SelectedIndexChanged += lstOrderItems_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(193, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(193, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha Pedido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(193, 84);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha Finalizado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(193, 113);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 5;
            label5.Text = "Costo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(193, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "Local:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(296, 27);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(52, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "lblStatus";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(296, 55);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(68, 15);
            lblStartDate.TabIndex = 9;
            lblStartDate.Text = "lblStartDate";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new System.Drawing.Point(296, 84);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(64, 15);
            lblEndDate.TabIndex = 10;
            lblEndDate.Text = "lblEndDate";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new System.Drawing.Point(296, 113);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(64, 15);
            lblAmount.TabIndex = 11;
            lblAmount.Text = "lblAmount";
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new System.Drawing.Point(296, 142);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new System.Drawing.Size(48, 15);
            lblLocal.TabIndex = 12;
            lblLocal.Text = "lblLocal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(193, 204);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(84, 15);
            label12.TabIndex = 13;
            label12.Text = "Platos pedidos";
            // 
            // lstDishes
            // 
            lstDishes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstDishes.FormattingEnabled = true;
            lstDishes.ItemHeight = 15;
            lstDishes.Location = new System.Drawing.Point(193, 222);
            lstDishes.Name = "lstDishes";
            lstDishes.Size = new System.Drawing.Size(250, 244);
            lstDishes.TabIndex = 14;
            // 
            // OrderMonitorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 482);
            Controls.Add(lstDishes);
            Controls.Add(label12);
            Controls.Add(lblLocal);
            Controls.Add(lblAmount);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblStatus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstOrderItems);
            Controls.Add(label1);
            Name = "OrderMonitorForm";
            Text = "OrderMonitorForm";
            Load += OrderMonitorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstDishes;
    }
}