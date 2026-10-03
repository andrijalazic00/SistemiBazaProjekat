namespace DigitalniRepozitorijum
{
    partial class FormDodajIstrazivaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajIstrazivaca));
            this.btnDodajIstrazivaca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.tbNaucnaOblast = new System.Windows.Forms.TextBox();
            this.tbNaucnoZvanje = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.cBoxUloga = new System.Windows.Forms.ComboBox();
            this.cBoxInstitucija = new System.Windows.Forms.ComboBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.btnDodajMail = new System.Windows.Forms.Button();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajIstrazivaca
            // 
            this.btnDodajIstrazivaca.Location = new System.Drawing.Point(391, 328);
            this.btnDodajIstrazivaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajIstrazivaca.Name = "btnDodajIstrazivaca";
            this.btnDodajIstrazivaca.Size = new System.Drawing.Size(233, 38);
            this.btnDodajIstrazivaca.TabIndex = 0;
            this.btnDodajIstrazivaca.Text = "Dodaj istrazivaca u bazu";
            this.btnDodajIstrazivaca.UseVisualStyleBackColor = true;
            this.btnDodajIstrazivaca.Click += new System.EventHandler(this.btnDodajIstrazivaca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drzava";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Naucna oblast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Naucno zvanje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status naucnika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Uloga";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 175);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Institucija";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(161, 33);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(297, 22);
            this.tbIme.TabIndex = 12;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(161, 81);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(297, 22);
            this.tbPrezime.TabIndex = 13;
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(161, 175);
            this.tbDrzava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.Size = new System.Drawing.Size(297, 22);
            this.tbDrzava.TabIndex = 15;
            // 
            // tbNaucnaOblast
            // 
            this.tbNaucnaOblast.Location = new System.Drawing.Point(161, 220);
            this.tbNaucnaOblast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNaucnaOblast.Name = "tbNaucnaOblast";
            this.tbNaucnaOblast.Size = new System.Drawing.Size(297, 22);
            this.tbNaucnaOblast.TabIndex = 16;
            // 
            // tbNaucnoZvanje
            // 
            this.tbNaucnoZvanje.Location = new System.Drawing.Point(161, 266);
            this.tbNaucnoZvanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNaucnoZvanje.Name = "tbNaucnoZvanje";
            this.tbNaucnoZvanje.Size = new System.Drawing.Size(297, 22);
            this.tbNaucnoZvanje.TabIndex = 17;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(595, 33);
            this.tbMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(297, 22);
            this.tbMail.TabIndex = 19;
            // 
            // cBoxUloga
            // 
            this.cBoxUloga.FormattingEnabled = true;
            this.cBoxUloga.Location = new System.Drawing.Point(595, 123);
            this.cBoxUloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxUloga.Name = "cBoxUloga";
            this.cBoxUloga.Size = new System.Drawing.Size(297, 24);
            this.cBoxUloga.TabIndex = 21;
            // 
            // cBoxInstitucija
            // 
            this.cBoxInstitucija.FormattingEnabled = true;
            this.cBoxInstitucija.Location = new System.Drawing.Point(595, 173);
            this.cBoxInstitucija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxInstitucija.Name = "cBoxInstitucija";
            this.cBoxInstitucija.Size = new System.Drawing.Size(297, 24);
            this.cBoxInstitucija.TabIndex = 22;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(595, 81);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(297, 22);
            this.tbTelefon.TabIndex = 20;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(161, 125);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(297, 22);
            this.dtpDatumRodjenja.TabIndex = 14;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(161, 311);
            this.cbAktivan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(70, 20);
            this.cbAktivan.TabIndex = 18;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnDodajMail
            // 
            this.btnDodajMail.Location = new System.Drawing.Point(919, 28);
            this.btnDodajMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajMail.Name = "btnDodajMail";
            this.btnDodajMail.Size = new System.Drawing.Size(117, 32);
            this.btnDodajMail.TabIndex = 24;
            this.btnDodajMail.Text = "Dodaj e-mail";
            this.btnDodajMail.UseVisualStyleBackColor = true;
            this.btnDodajMail.Click += new System.EventHandler(this.btnDodajMail_Click);
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.Location = new System.Drawing.Point(919, 76);
            this.btnDodajTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(117, 32);
            this.btnDodajTelefon.TabIndex = 25;
            this.btnDodajTelefon.Text = "Dodaj telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(919, 118);
            this.btnDodajUlogu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(117, 32);
            this.btnDodajUlogu.TabIndex = 26;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // FormDodajIstrazivaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 414);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.btnDodajTelefon);
            this.Controls.Add(this.btnDodajMail);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.cBoxInstitucija);
            this.Controls.Add(this.cBoxUloga);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbNaucnoZvanje);
            this.Controls.Add(this.tbNaucnaOblast);
            this.Controls.Add(this.tbDrzava);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajIstrazivaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodajIstrazivaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj istrazivaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajIstrazivaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.TextBox tbNaucnaOblast;
        private System.Windows.Forms.TextBox tbNaucnoZvanje;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.ComboBox cBoxUloga;
        private System.Windows.Forms.ComboBox cBoxInstitucija;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.Button btnDodajMail;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnDodajUlogu;
    }
}