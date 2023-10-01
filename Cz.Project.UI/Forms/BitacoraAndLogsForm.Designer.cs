namespace Cz.Project.UI.Forms
{
    partial class BitacoraAndLogsForm
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
            cmbType = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            lstBitacora = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new System.Drawing.Point(106, 6);
            cmbType.Name = "cmbType";
            cmbType.Size = new System.Drawing.Size(317, 23);
            cmbType.TabIndex = 0;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo de evento:";
            // 
            // lstBitacora
            // 
            lstBitacora.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstBitacora.FormattingEnabled = true;
            lstBitacora.HorizontalScrollbar = true;
            lstBitacora.ItemHeight = 15;
            lstBitacora.Location = new System.Drawing.Point(12, 35);
            lstBitacora.Name = "lstBitacora";
            lstBitacora.Size = new System.Drawing.Size(411, 289);
            lstBitacora.TabIndex = 2;
            // 
            // BitacoraAndLogsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(438, 339);
            Controls.Add(lstBitacora);
            Controls.Add(label1);
            Controls.Add(cmbType);
            Name = "BitacoraAndLogsForm";
            Text = "BitacoraForm";
            Load += BitacoraAndLogsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBitacora;
    }
}