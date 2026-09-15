namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiTelefon
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
            this.btnObrisiTelefon = new System.Windows.Forms.Button();
            this.comboBoxTelefon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon za brisanje";
            // 
            // btnObrisiTelefon
            // 
            this.btnObrisiTelefon.Location = new System.Drawing.Point(44, 76);
            this.btnObrisiTelefon.Name = "btnObrisiTelefon";
            this.btnObrisiTelefon.Size = new System.Drawing.Size(192, 27);
            this.btnObrisiTelefon.TabIndex = 1;
            this.btnObrisiTelefon.Text = "Obrisi";
            this.btnObrisiTelefon.UseVisualStyleBackColor = true;
            this.btnObrisiTelefon.Click += new System.EventHandler(this.btnObrisiTelefon_Click);
            // 
            // comboBoxTelefon
            // 
            this.comboBoxTelefon.FormattingEnabled = true;
            this.comboBoxTelefon.Location = new System.Drawing.Point(130, 38);
            this.comboBoxTelefon.Name = "comboBoxTelefon";
            this.comboBoxTelefon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTelefon.TabIndex = 2;
            // 
            // FormObrisiTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 147);
            this.Controls.Add(this.comboBoxTelefon);
            this.Controls.Add(this.btnObrisiTelefon);
            this.Controls.Add(this.label1);
            this.Name = "FormObrisiTelefon";
            this.Text = "FormObrisiTelefon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiTelefon;
        private System.Windows.Forms.ComboBox comboBoxTelefon;
    }
}