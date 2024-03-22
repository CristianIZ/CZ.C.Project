namespace Cz.Project.UI
{
    partial class ABMLanguajeForm
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnAddLanguaje = new System.Windows.Forms.Button();
            txtNewLanguaje = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnSetTranslation = new System.Windows.Forms.Button();
            txtTranslation = new System.Windows.Forms.TextBox();
            cmbWord = new System.Windows.Forms.ComboBox();
            cmbTargetLanguaje = new System.Windows.Forms.ComboBox();
            cmbSourceLanguaje = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddLanguaje);
            groupBox1.Controls.Add(txtNewLanguaje);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(419, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Lenguaje";
            // 
            // btnAddLanguaje
            // 
            btnAddLanguaje.Location = new System.Drawing.Point(238, 50);
            btnAddLanguaje.Name = "btnAddLanguaje";
            btnAddLanguaje.Size = new System.Drawing.Size(171, 23);
            btnAddLanguaje.TabIndex = 2;
            btnAddLanguaje.Text = "Crear Lenguaje";
            btnAddLanguaje.UseVisualStyleBackColor = true;
            btnAddLanguaje.Click += btnAddLanguaje_Click;
            // 
            // txtNewLanguaje
            // 
            txtNewLanguaje.Location = new System.Drawing.Point(6, 50);
            txtNewLanguaje.Name = "txtNewLanguaje";
            txtNewLanguaje.Size = new System.Drawing.Size(171, 23);
            txtNewLanguaje.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSetTranslation);
            groupBox2.Controls.Add(txtTranslation);
            groupBox2.Controls.Add(cmbWord);
            groupBox2.Controls.Add(cmbTargetLanguaje);
            groupBox2.Controls.Add(cmbSourceLanguaje);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new System.Drawing.Point(12, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(419, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Asignar traducciones";
            // 
            // btnSetTranslation
            // 
            btnSetTranslation.Location = new System.Drawing.Point(238, 167);
            btnSetTranslation.Name = "btnSetTranslation";
            btnSetTranslation.Size = new System.Drawing.Size(171, 23);
            btnSetTranslation.TabIndex = 8;
            btnSetTranslation.Text = "Asignar traduccion";
            btnSetTranslation.UseVisualStyleBackColor = true;
            btnSetTranslation.Click += btnSetTranslation_Click;
            // 
            // txtTranslation
            // 
            txtTranslation.Location = new System.Drawing.Point(238, 123);
            txtTranslation.Name = "txtTranslation";
            txtTranslation.Size = new System.Drawing.Size(171, 23);
            txtTranslation.TabIndex = 7;
            // 
            // cmbWord
            // 
            cmbWord.FormattingEnabled = true;
            cmbWord.Location = new System.Drawing.Point(6, 123);
            cmbWord.Name = "cmbWord";
            cmbWord.Size = new System.Drawing.Size(171, 23);
            cmbWord.TabIndex = 6;
            // 
            // cmbTargetLanguaje
            // 
            cmbTargetLanguaje.FormattingEnabled = true;
            cmbTargetLanguaje.Location = new System.Drawing.Point(238, 57);
            cmbTargetLanguaje.Name = "cmbTargetLanguaje";
            cmbTargetLanguaje.Size = new System.Drawing.Size(171, 23);
            cmbTargetLanguaje.TabIndex = 5;
            // 
            // cmbSourceLanguaje
            // 
            cmbSourceLanguaje.FormattingEnabled = true;
            cmbSourceLanguaje.Location = new System.Drawing.Point(6, 57);
            cmbSourceLanguaje.Name = "cmbSourceLanguaje";
            cmbSourceLanguaje.Size = new System.Drawing.Size(171, 23);
            cmbSourceLanguaje.TabIndex = 4;
            cmbSourceLanguaje.SelectedIndexChanged += cmbSourceLanguaje_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(238, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 15);
            label5.TabIndex = 3;
            label5.Text = "Traduccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 2;
            label4.Text = "Palabra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(238, 39);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Lenguaje destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Lenguaje origen";
            // 
            // ABMLanguajeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(445, 318);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ABMLanguajeForm";
            Text = "Nuevo Lenguaje";
            Load += ABMLanguajeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNewLanguaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.ComboBox cmbWord;
        private System.Windows.Forms.ComboBox cmbTargetLanguaje;
        private System.Windows.Forms.ComboBox cmbSourceLanguaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetTranslation;
        private System.Windows.Forms.Button btnAddLanguaje;
    }
}