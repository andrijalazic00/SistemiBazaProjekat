namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiKljucnuRec
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
            this.comboBoxKljucnaRec = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kljucna rec za brisanje";
            // 
            // comboBoxKljucnaRec
            // 
            this.comboBoxKljucnaRec.FormattingEnabled = true;
            this.comboBoxKljucnaRec.Location = new System.Drawing.Point(147, 18);
            this.comboBoxKljucnaRec.Name = "comboBoxKljucnaRec";
            this.comboBoxKljucnaRec.Size = new System.Drawing.Size(154, 21);
            this.comboBoxKljucnaRec.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(46, 58);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(233, 32);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi kljucnu rec";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormObrisiKljucnuRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.comboBoxKljucnaRec);
            this.Controls.Add(this.label1);
            this.Name = "FormObrisiKljucnuRec";
            this.Text = "FormObrisiKljucnuRec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKljucnaRec;
        private System.Windows.Forms.Button btnObrisi;
    }
}