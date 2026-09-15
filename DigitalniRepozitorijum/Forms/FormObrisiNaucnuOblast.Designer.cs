namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiNaucnuOblast
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
            this.comboBoxNaucnaOblast = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naucna oblast za brisanje";
            // 
            // comboBoxNaucnaOblast
            // 
            this.comboBoxNaucnaOblast.FormattingEnabled = true;
            this.comboBoxNaucnaOblast.Location = new System.Drawing.Point(175, 33);
            this.comboBoxNaucnaOblast.Name = "comboBoxNaucnaOblast";
            this.comboBoxNaucnaOblast.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNaucnaOblast.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(78, 84);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 30);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormObrisiNaucnuOblast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 176);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.comboBoxNaucnaOblast);
            this.Controls.Add(this.label1);
            this.Name = "FormObrisiNaucnuOblast";
            this.Text = "FormObrisiNaucnuOblast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNaucnaOblast;
        private System.Windows.Forms.Button btnObrisi;
    }
}