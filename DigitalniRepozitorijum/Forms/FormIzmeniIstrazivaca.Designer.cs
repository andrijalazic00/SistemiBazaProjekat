namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniIstrazivaca
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
            this.comboBIstrazivac = new System.Windows.Forms.ComboBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.btnDodajMail = new System.Windows.Forms.Button();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.cBoxUloga = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNaucnoZvanje = new System.Windows.Forms.TextBox();
            this.tbNaucnaOblast = new System.Windows.Forms.TextBox();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.gbAzuriranje = new System.Windows.Forms.GroupBox();
            this.btnObrisiUlogu = new System.Windows.Forms.Button();
            this.btnObrisiTelefon = new System.Windows.Forms.Button();
            this.btnObrisiMail = new System.Windows.Forms.Button();
            this.gbObrisi = new System.Windows.Forms.GroupBox();
            this.gbAzuriranje.SuspendLayout();
            this.gbObrisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Istrazivac";
            // 
            // comboBIstrazivac
            // 
            this.comboBIstrazivac.FormattingEnabled = true;
            this.comboBIstrazivac.Location = new System.Drawing.Point(160, 27);
            this.comboBIstrazivac.Margin = new System.Windows.Forms.Padding(4);
            this.comboBIstrazivac.Name = "comboBIstrazivac";
            this.comboBIstrazivac.Size = new System.Drawing.Size(210, 24);
            this.comboBIstrazivac.TabIndex = 1;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Location = new System.Drawing.Point(407, 28);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(177, 23);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Location = new System.Drawing.Point(612, 28);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(177, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(472, 181);
            this.btnDodajUlogu.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(151, 23);
            this.btnDodajUlogu.TabIndex = 52;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.Location = new System.Drawing.Point(474, 115);
            this.btnDodajTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(151, 23);
            this.btnDodajTelefon.TabIndex = 51;
            this.btnDodajTelefon.Text = "Dodaj telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // btnDodajMail
            // 
            this.btnDodajMail.Location = new System.Drawing.Point(474, 55);
            this.btnDodajMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajMail.Name = "btnDodajMail";
            this.btnDodajMail.Size = new System.Drawing.Size(149, 23);
            this.btnDodajMail.TabIndex = 50;
            this.btnDodajMail.Text = "Dodaj e-mail";
            this.btnDodajMail.UseVisualStyleBackColor = true;
            this.btnDodajMail.Click += new System.EventHandler(this.btnDodajMail_Click);
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(160, 214);
            this.cbAktivan.Margin = new System.Windows.Forms.Padding(4);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(70, 20);
            this.cbAktivan.TabIndex = 49;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(160, 85);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(210, 22);
            this.dtpDatumRodjenja.TabIndex = 48;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(474, 85);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(312, 22);
            this.tbTelefon.TabIndex = 45;
            // 
            // cBoxUloga
            // 
            this.cBoxUloga.FormattingEnabled = true;
            this.cBoxUloga.Location = new System.Drawing.Point(474, 148);
            this.cBoxUloga.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxUloga.Name = "cBoxUloga";
            this.cBoxUloga.Size = new System.Drawing.Size(312, 24);
            this.cBoxUloga.TabIndex = 45;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(474, 25);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(310, 22);
            this.tbMail.TabIndex = 44;
            // 
            // tbNaucnoZvanje
            // 
            this.tbNaucnoZvanje.Location = new System.Drawing.Point(160, 178);
            this.tbNaucnoZvanje.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaucnoZvanje.Name = "tbNaucnoZvanje";
            this.tbNaucnoZvanje.Size = new System.Drawing.Size(210, 22);
            this.tbNaucnoZvanje.TabIndex = 43;
            // 
            // tbNaucnaOblast
            // 
            this.tbNaucnaOblast.Location = new System.Drawing.Point(160, 148);
            this.tbNaucnaOblast.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaucnaOblast.Name = "tbNaucnaOblast";
            this.tbNaucnaOblast.Size = new System.Drawing.Size(210, 22);
            this.tbNaucnaOblast.TabIndex = 42;
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(160, 118);
            this.tbDrzava.Margin = new System.Windows.Forms.Padding(4);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.Size = new System.Drawing.Size(210, 22);
            this.tbDrzava.TabIndex = 41;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(160, 55);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(210, 22);
            this.tbPrezime.TabIndex = 40;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(160, 25);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(210, 22);
            this.tbIme.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Uloga";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Status naucnika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Naucno zvanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Naucna oblast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Drzava";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Datum rodjenja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Prezime";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ime";
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.BackColor = System.Drawing.SystemColors.Control;
            this.btnSacuvajIzmene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(301, 241);
            this.btnSacuvajIzmene.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(233, 38);
            this.btnSacuvajIzmene.TabIndex = 27;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = false;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // gbAzuriranje
            // 
            this.gbAzuriranje.Controls.Add(this.btnObrisiUlogu);
            this.gbAzuriranje.Controls.Add(this.btnObrisiTelefon);
            this.gbAzuriranje.Controls.Add(this.btnObrisiMail);
            this.gbAzuriranje.Controls.Add(this.btnDodajUlogu);
            this.gbAzuriranje.Controls.Add(this.btnDodajTelefon);
            this.gbAzuriranje.Controls.Add(this.btnDodajMail);
            this.gbAzuriranje.Controls.Add(this.cbAktivan);
            this.gbAzuriranje.Controls.Add(this.dtpDatumRodjenja);
            this.gbAzuriranje.Controls.Add(this.tbTelefon);
            this.gbAzuriranje.Controls.Add(this.cBoxUloga);
            this.gbAzuriranje.Controls.Add(this.tbMail);
            this.gbAzuriranje.Controls.Add(this.tbNaucnoZvanje);
            this.gbAzuriranje.Controls.Add(this.tbNaucnaOblast);
            this.gbAzuriranje.Controls.Add(this.tbDrzava);
            this.gbAzuriranje.Controls.Add(this.tbPrezime);
            this.gbAzuriranje.Controls.Add(this.tbIme);
            this.gbAzuriranje.Controls.Add(this.label10);
            this.gbAzuriranje.Controls.Add(this.label9);
            this.gbAzuriranje.Controls.Add(this.label8);
            this.gbAzuriranje.Controls.Add(this.label7);
            this.gbAzuriranje.Controls.Add(this.label6);
            this.gbAzuriranje.Controls.Add(this.label5);
            this.gbAzuriranje.Controls.Add(this.label4);
            this.gbAzuriranje.Controls.Add(this.label3);
            this.gbAzuriranje.Controls.Add(this.label2);
            this.gbAzuriranje.Controls.Add(this.label12);
            this.gbAzuriranje.Controls.Add(this.btnSacuvajIzmene);
            this.gbAzuriranje.Enabled = false;
            this.gbAzuriranje.Location = new System.Drawing.Point(50, 82);
            this.gbAzuriranje.Margin = new System.Windows.Forms.Padding(4);
            this.gbAzuriranje.Name = "gbAzuriranje";
            this.gbAzuriranje.Padding = new System.Windows.Forms.Padding(4);
            this.gbAzuriranje.Size = new System.Drawing.Size(841, 308);
            this.gbAzuriranje.TabIndex = 53;
            this.gbAzuriranje.TabStop = false;
            // 
            // btnObrisiUlogu
            // 
            this.btnObrisiUlogu.Location = new System.Drawing.Point(635, 181);
            this.btnObrisiUlogu.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiUlogu.Name = "btnObrisiUlogu";
            this.btnObrisiUlogu.Size = new System.Drawing.Size(151, 23);
            this.btnObrisiUlogu.TabIndex = 55;
            this.btnObrisiUlogu.Text = "Obrisi ulogu";
            this.btnObrisiUlogu.UseVisualStyleBackColor = true;
            this.btnObrisiUlogu.Click += new System.EventHandler(this.btnObrisiUlogu_Click);
            // 
            // btnObrisiTelefon
            // 
            this.btnObrisiTelefon.Location = new System.Drawing.Point(633, 114);
            this.btnObrisiTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTelefon.Name = "btnObrisiTelefon";
            this.btnObrisiTelefon.Size = new System.Drawing.Size(151, 23);
            this.btnObrisiTelefon.TabIndex = 54;
            this.btnObrisiTelefon.Text = "Obrisi telefon";
            this.btnObrisiTelefon.UseVisualStyleBackColor = true;
            this.btnObrisiTelefon.Click += new System.EventHandler(this.btnObrisiTelefon_Click);
            // 
            // btnObrisiMail
            // 
            this.btnObrisiMail.Location = new System.Drawing.Point(635, 55);
            this.btnObrisiMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiMail.Name = "btnObrisiMail";
            this.btnObrisiMail.Size = new System.Drawing.Size(151, 23);
            this.btnObrisiMail.TabIndex = 53;
            this.btnObrisiMail.Text = "Obrisi e-mail";
            this.btnObrisiMail.UseVisualStyleBackColor = true;
            this.btnObrisiMail.Click += new System.EventHandler(this.btnObrisiMail_Click);
            // 
            // gbObrisi
            // 
            this.gbObrisi.Controls.Add(this.btnObrisi);
            this.gbObrisi.Controls.Add(this.btnIzmeni);
            this.gbObrisi.Controls.Add(this.comboBIstrazivac);
            this.gbObrisi.Controls.Add(this.label1);
            this.gbObrisi.Location = new System.Drawing.Point(50, 13);
            this.gbObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.gbObrisi.Name = "gbObrisi";
            this.gbObrisi.Padding = new System.Windows.Forms.Padding(4);
            this.gbObrisi.Size = new System.Drawing.Size(841, 69);
            this.gbObrisi.TabIndex = 54;
            this.gbObrisi.TabStop = false;
            // 
            // FormIzmeniIstrazivaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 417);
            this.Controls.Add(this.gbObrisi);
            this.Controls.Add(this.gbAzuriranje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIzmeniIstrazivaca";
            this.Text = "Izmene istrazivaca";
            this.gbAzuriranje.ResumeLayout(false);
            this.gbAzuriranje.PerformLayout();
            this.gbObrisi.ResumeLayout(false);
            this.gbObrisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBIstrazivac;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnDodajMail;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ComboBox cBoxUloga;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNaucnoZvanje;
        private System.Windows.Forms.TextBox tbNaucnaOblast;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSacuvajIzmene;
        private System.Windows.Forms.GroupBox gbAzuriranje;
        private System.Windows.Forms.GroupBox gbObrisi;
        private System.Windows.Forms.Button btnObrisiUlogu;
        private System.Windows.Forms.Button btnObrisiTelefon;
        private System.Windows.Forms.Button btnObrisiMail;
    }
}