namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiUlogu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiUlogu = new System.Windows.Forms.Button();
            this.comboBoxUloga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uloga za brisanje";
            // 
            // btnObrisiUlogu
            // 
            this.btnObrisiUlogu.Location = new System.Drawing.Point(120, 63);
            this.btnObrisiUlogu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiUlogu.Name = "btnObrisiUlogu";
            this.btnObrisiUlogu.Size = new System.Drawing.Size(267, 31);
            this.btnObrisiUlogu.TabIndex = 1;
            this.btnObrisiUlogu.Text = "Obrisi";
            this.btnObrisiUlogu.UseVisualStyleBackColor = true;
            this.btnObrisiUlogu.Click += new System.EventHandler(this.btnObrisiUlogu_Click);
            // 
            // comboBoxUloga
            // 
            this.comboBoxUloga.FormattingEnabled = true;
            this.comboBoxUloga.Location = new System.Drawing.Point(157, 31);
            this.comboBoxUloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUloga.Name = "comboBoxUloga";
            this.comboBoxUloga.Size = new System.Drawing.Size(332, 24);
            this.comboBoxUloga.TabIndex = 2;
            // 
            // FormObrisiUlogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 123);
            this.Controls.Add(this.comboBoxUloga);
            this.Controls.Add(this.btnObrisiUlogu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormObrisiUlogu";
            this.Text = "FormObrisiUlogu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiUlogu;
        private System.Windows.Forms.ComboBox comboBoxUloga;
    }
}