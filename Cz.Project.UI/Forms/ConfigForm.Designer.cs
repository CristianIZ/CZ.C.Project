namespace Cz.Project.UI.Forms
{
    partial class ConfigForm
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
            cmbLanguaje = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Lenguaje:";
            // 
            // cmbLanguaje
            // 
            cmbLanguaje.FormattingEnabled = true;
            cmbLanguaje.Location = new System.Drawing.Point(76, 20);
            cmbLanguaje.Name = "cmbLanguaje";
            cmbLanguaje.Size = new System.Drawing.Size(161, 23);
            cmbLanguaje.TabIndex = 1;
            cmbLanguaje.SelectedIndexChanged += cmbLanguaje_SelectedIndexChanged;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(559, 429);
            Controls.Add(cmbLanguaje);
            Controls.Add(label1);
            Name = "ConfigForm";
            Text = "ConfigForm";
            Load += ConfigForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguaje;
    }
}