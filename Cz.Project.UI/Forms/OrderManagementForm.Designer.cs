namespace Cz.Project.UI.Forms
{
    partial class OrderManagementForm
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
            components = new System.ComponentModel.Container();
            dgvOrders = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            btnAcceptOrder = new System.Windows.Forms.Button();
            btnDeliver = new System.Windows.Forms.Button();
            btnRejectOrder = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new System.Drawing.Point(12, 35);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.Size = new System.Drawing.Size(694, 257);
            dgvOrders.TabIndex = 2;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Ordenes";
            // 
            // btnAcceptOrder
            // 
            btnAcceptOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAcceptOrder.Location = new System.Drawing.Point(12, 298);
            btnAcceptOrder.Name = "btnAcceptOrder";
            btnAcceptOrder.Size = new System.Drawing.Size(119, 29);
            btnAcceptOrder.TabIndex = 6;
            btnAcceptOrder.Text = "Accept order";
            btnAcceptOrder.UseVisualStyleBackColor = true;
            btnAcceptOrder.Click += btnAcceptOrder_Click;
            // 
            // btnDeliver
            // 
            btnDeliver.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDeliver.Location = new System.Drawing.Point(262, 298);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new System.Drawing.Size(119, 29);
            btnDeliver.TabIndex = 7;
            btnDeliver.Text = "Deliver Order";
            btnDeliver.UseVisualStyleBackColor = true;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // btnRejectOrder
            // 
            btnRejectOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnRejectOrder.Location = new System.Drawing.Point(137, 298);
            btnRejectOrder.Name = "btnRejectOrder";
            btnRejectOrder.Size = new System.Drawing.Size(119, 29);
            btnRejectOrder.TabIndex = 9;
            btnRejectOrder.Text = "Reject";
            btnRejectOrder.UseVisualStyleBackColor = true;
            btnRejectOrder.Click += btnRejectOrder_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(718, 338);
            Controls.Add(btnRejectOrder);
            Controls.Add(btnDeliver);
            Controls.Add(btnAcceptOrder);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Name = "OrderManagementForm";
            Text = "Gestion de Ordenes";
            Load += OrderManagementForm_Load;
            Shown += OrderManagementForm_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcceptOrder;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnRejectOrder;
        private System.Windows.Forms.Timer timer1;
    }
}