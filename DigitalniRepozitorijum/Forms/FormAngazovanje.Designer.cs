namespace DigitalniRepozitorijum.Forms
{
    partial class FormAngazovanje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNazivPozicije = new System.Windows.Forms.TextBox();
            this.lbTip = new System.Windows.Forms.ListBox();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.tbOrganizacionaJedinica = new System.Windows.Forms.TextBox();
            this.btnDodajAngazovanje = new System.Windows.Forms.Button();
            this.comboBInstitucija = new System.Windows.Forms.ComboBox();
            this.comboBIstrazivac = new System.Windows.Forms.ComboBox();
            this.lblInstitucija = new System.Windows.Forms.Label();
            this.lblIstrazivac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv pozicije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip angazovanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum pocetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum zavrsetka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Organizaciona jedinica";
            // 
            // tbNazivPozicije
            // 
            this.tbNazivPozicije.Location = new System.Drawing.Point(176, 33);
            this.tbNazivPozicije.Name = "tbNazivPozicije";
            this.tbNazivPozicije.Size = new System.Drawing.Size(101, 20);
            this.tbNazivPozicije.TabIndex = 5;
            // 
            // lbTip
            // 
            this.lbTip.FormattingEnabled = true;
            this.lbTip.Location = new System.Drawing.Point(179, 75);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(97, 17);
            this.lbTip.TabIndex = 6;
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Location = new System.Drawing.Point(174, 121);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(102, 20);
            this.dtpDatumPocetka.TabIndex = 7;
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(168, 181);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(107, 20);
            this.dtpDatumZavrsetka.TabIndex = 8;
            // 
            // tbOrganizacionaJedinica
            // 
            this.tbOrganizacionaJedinica.Location = new System.Drawing.Point(171, 240);
            this.tbOrganizacionaJedinica.Name = "tbOrganizacionaJedinica";
            this.tbOrganizacionaJedinica.Size = new System.Drawing.Size(106, 20);
            this.tbOrganizacionaJedinica.TabIndex = 9;
            // 
            // btnDodajAngazovanje
            // 
            this.btnDodajAngazovanje.Location = new System.Drawing.Point(114, 317);
            this.btnDodajAngazovanje.Name = "btnDodajAngazovanje";
            this.btnDodajAngazovanje.Size = new System.Drawing.Size(159, 27);
            this.btnDodajAngazovanje.TabIndex = 10;
            this.btnDodajAngazovanje.Text = "Dodaj angazovanje";
            this.btnDodajAngazovanje.UseVisualStyleBackColor = true;
            this.btnDodajAngazovanje.Click += new System.EventHandler(this.btnDodajAngazovanje_Click);
            // 
            // comboBInstitucija
            // 
            this.comboBInstitucija.FormattingEnabled = true;
            this.comboBInstitucija.Location = new System.Drawing.Point(488, 33);
            this.comboBInstitucija.Name = "comboBInstitucija";
            this.comboBInstitucija.Size = new System.Drawing.Size(114, 21);
            this.comboBInstitucija.TabIndex = 11;
            // 
            // comboBIstrazivac
            // 
            this.comboBIstrazivac.FormattingEnabled = true;
            this.comboBIstrazivac.Location = new System.Drawing.Point(488, 81);
            this.comboBIstrazivac.Name = "comboBIstrazivac";
            this.comboBIstrazivac.Size = new System.Drawing.Size(113, 21);
            this.comboBIstrazivac.TabIndex = 12;
            // 
            // lblInstitucija
            // 
            this.lblInstitucija.AutoSize = true;
            this.lblInstitucija.Location = new System.Drawing.Point(356, 32);
            this.lblInstitucija.Name = "lblInstitucija";
            this.lblInstitucija.Size = new System.Drawing.Size(51, 13);
            this.lblInstitucija.TabIndex = 13;
            this.lblInstitucija.Text = "Institucija";
            // 
            // lblIstrazivac
            // 
            this.lblIstrazivac.AutoSize = true;
            this.lblIstrazivac.Location = new System.Drawing.Point(354, 87);
            this.lblIstrazivac.Name = "lblIstrazivac";
            this.lblIstrazivac.Size = new System.Drawing.Size(52, 13);
            this.lblIstrazivac.TabIndex = 14;
            this.lblIstrazivac.Text = "Istrazivac";
            // 
            // FormAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIstrazivac);
            this.Controls.Add(this.lblInstitucija);
            this.Controls.Add(this.comboBIstrazivac);
            this.Controls.Add(this.comboBInstitucija);
            this.Controls.Add(this.btnDodajAngazovanje);
            this.Controls.Add(this.tbOrganizacionaJedinica);
            this.Controls.Add(this.dtpDatumZavrsetka);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.tbNazivPozicije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAngazovanje";
            this.Text = "FormAngazovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNazivPozicije;
        private System.Windows.Forms.ListBox lbTip;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.TextBox tbOrganizacionaJedinica;
        private System.Windows.Forms.Button btnDodajAngazovanje;
        private System.Windows.Forms.ComboBox comboBInstitucija;
        private System.Windows.Forms.ComboBox comboBIstrazivac;
        private System.Windows.Forms.Label lblInstitucija;
        private System.Windows.Forms.Label lblIstrazivac;
    }
}