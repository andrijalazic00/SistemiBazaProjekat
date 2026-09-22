namespace DigitalniRepozitorijum.Forms
{
    partial class FormDodajCitat
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
            this.lblCitirajucaPublikacija = new System.Windows.Forms.Label();
            this.lblCitiranaPublikacija = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBCitirajucaPublikacija = new System.Windows.Forms.ComboBox();
            this.comboBCitiranaPublikacija = new System.Windows.Forms.ComboBox();
            this.tbKontekstCitiranja = new System.Windows.Forms.TextBox();
            this.tbMestoCitiranja = new System.Windows.Forms.TextBox();
            this.cbTipCitata = new System.Windows.Forms.CheckBox();
            this.btnSacuvajCitat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCitirajucaPublikacija
            // 
            this.lblCitirajucaPublikacija.AutoSize = true;
            this.lblCitirajucaPublikacija.Location = new System.Drawing.Point(12, 22);
            this.lblCitirajucaPublikacija.Name = "lblCitirajucaPublikacija";
            this.lblCitirajucaPublikacija.Size = new System.Drawing.Size(103, 13);
            this.lblCitirajucaPublikacija.TabIndex = 0;
            this.lblCitirajucaPublikacija.Text = "Citirajuca publikacija";
            // 
            // lblCitiranaPublikacija
            // 
            this.lblCitiranaPublikacija.AutoSize = true;
            this.lblCitiranaPublikacija.Location = new System.Drawing.Point(20, 61);
            this.lblCitiranaPublikacija.Name = "lblCitiranaPublikacija";
            this.lblCitiranaPublikacija.Size = new System.Drawing.Size(95, 13);
            this.lblCitiranaPublikacija.TabIndex = 1;
            this.lblCitiranaPublikacija.Text = "Citirana publikacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontekst citiranja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesto citiranja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip citata";
            // 
            // comboBCitirajucaPublikacija
            // 
            this.comboBCitirajucaPublikacija.FormattingEnabled = true;
            this.comboBCitirajucaPublikacija.Location = new System.Drawing.Point(139, 19);
            this.comboBCitirajucaPublikacija.Name = "comboBCitirajucaPublikacija";
            this.comboBCitirajucaPublikacija.Size = new System.Drawing.Size(174, 21);
            this.comboBCitirajucaPublikacija.TabIndex = 7;
            // 
            // comboBCitiranaPublikacija
            // 
            this.comboBCitiranaPublikacija.FormattingEnabled = true;
            this.comboBCitiranaPublikacija.Location = new System.Drawing.Point(139, 58);
            this.comboBCitiranaPublikacija.Name = "comboBCitiranaPublikacija";
            this.comboBCitiranaPublikacija.Size = new System.Drawing.Size(174, 21);
            this.comboBCitiranaPublikacija.TabIndex = 8;
            // 
            // tbKontekstCitiranja
            // 
            this.tbKontekstCitiranja.Location = new System.Drawing.Point(139, 95);
            this.tbKontekstCitiranja.Name = "tbKontekstCitiranja";
            this.tbKontekstCitiranja.Size = new System.Drawing.Size(174, 20);
            this.tbKontekstCitiranja.TabIndex = 9;
            // 
            // tbMestoCitiranja
            // 
            this.tbMestoCitiranja.Location = new System.Drawing.Point(139, 133);
            this.tbMestoCitiranja.Name = "tbMestoCitiranja";
            this.tbMestoCitiranja.Size = new System.Drawing.Size(174, 20);
            this.tbMestoCitiranja.TabIndex = 10;
            // 
            // cbTipCitata
            // 
            this.cbTipCitata.AutoSize = true;
            this.cbTipCitata.Location = new System.Drawing.Point(139, 171);
            this.cbTipCitata.Name = "cbTipCitata";
            this.cbTipCitata.Size = new System.Drawing.Size(81, 17);
            this.cbTipCitata.TabIndex = 11;
            this.cbTipCitata.Text = "DIREKTAN";
            this.cbTipCitata.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajCitat
            // 
            this.btnSacuvajCitat.Location = new System.Drawing.Point(35, 214);
            this.btnSacuvajCitat.Name = "btnSacuvajCitat";
            this.btnSacuvajCitat.Size = new System.Drawing.Size(251, 28);
            this.btnSacuvajCitat.TabIndex = 12;
            this.btnSacuvajCitat.Text = "Sacuvaj citat";
            this.btnSacuvajCitat.UseVisualStyleBackColor = true;
            this.btnSacuvajCitat.Click += new System.EventHandler(this.btnSacuvajCitat_Click);
            // 
            // FormDodajCitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajCitat);
            this.Controls.Add(this.cbTipCitata);
            this.Controls.Add(this.tbMestoCitiranja);
            this.Controls.Add(this.tbKontekstCitiranja);
            this.Controls.Add(this.comboBCitiranaPublikacija);
            this.Controls.Add(this.comboBCitirajucaPublikacija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCitiranaPublikacija);
            this.Controls.Add(this.lblCitirajucaPublikacija);
            this.Name = "FormDodajCitat";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCitirajucaPublikacija;
        private System.Windows.Forms.Label lblCitiranaPublikacija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBCitirajucaPublikacija;
        private System.Windows.Forms.ComboBox comboBCitiranaPublikacija;
        private System.Windows.Forms.TextBox tbKontekstCitiranja;
        private System.Windows.Forms.TextBox tbMestoCitiranja;
        private System.Windows.Forms.CheckBox cbTipCitata;
        private System.Windows.Forms.Button btnSacuvajCitat;
    }
}