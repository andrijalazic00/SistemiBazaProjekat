namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniIR
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
            this.btnPredjiNaPodklasu = new System.Windows.Forms.Button();
            this.btnDodajVerziju = new System.Windows.Forms.Button();
            this.btnDodajKljucnuRec = new System.Windows.Forms.Button();
            this.tbKljucnaRec = new System.Windows.Forms.TextBox();
            this.cbVidljivost = new System.Windows.Forms.CheckBox();
            this.comboBStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatumObjavljivanja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumKreiranja = new System.Windows.Forms.DateTimePicker();
            this.tbApstrakt = new System.Windows.Forms.TextBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbObrisi = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.comboBIstrazivackiRezultat = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbAzuriraj = new System.Windows.Forms.GroupBox();
            this.btnObrisiVerziju = new System.Windows.Forms.Button();
            this.btnObrisiKljucnuRec = new System.Windows.Forms.Button();
            this.gbObrisi.SuspendLayout();
            this.gbAzuriraj.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPredjiNaPodklasu
            // 
            this.btnPredjiNaPodklasu.BackColor = System.Drawing.SystemColors.Control;
            this.btnPredjiNaPodklasu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredjiNaPodklasu.Location = new System.Drawing.Point(323, 198);
            this.btnPredjiNaPodklasu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredjiNaPodklasu.Name = "btnPredjiNaPodklasu";
            this.btnPredjiNaPodklasu.Size = new System.Drawing.Size(324, 37);
            this.btnPredjiNaPodklasu.TabIndex = 40;
            this.btnPredjiNaPodklasu.Text = "Predji na atribute vezane za tip";
            this.btnPredjiNaPodklasu.UseVisualStyleBackColor = false;
            this.btnPredjiNaPodklasu.Click += new System.EventHandler(this.btnPredjiNaPodklasu_Click);
            // 
            // btnDodajVerziju
            // 
            this.btnDodajVerziju.Location = new System.Drawing.Point(512, 150);
            this.btnDodajVerziju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajVerziju.Name = "btnDodajVerziju";
            this.btnDodajVerziju.Size = new System.Drawing.Size(135, 26);
            this.btnDodajVerziju.TabIndex = 39;
            this.btnDodajVerziju.Text = "Dodaj verziju";
            this.btnDodajVerziju.UseVisualStyleBackColor = true;
            this.btnDodajVerziju.Click += new System.EventHandler(this.btnDodajVerziju_Click);
            // 
            // btnDodajKljucnuRec
            // 
            this.btnDodajKljucnuRec.Location = new System.Drawing.Point(689, 112);
            this.btnDodajKljucnuRec.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajKljucnuRec.Name = "btnDodajKljucnuRec";
            this.btnDodajKljucnuRec.Size = new System.Drawing.Size(135, 26);
            this.btnDodajKljucnuRec.TabIndex = 38;
            this.btnDodajKljucnuRec.Text = "Dodaj kljucnu rec";
            this.btnDodajKljucnuRec.UseVisualStyleBackColor = true;
            this.btnDodajKljucnuRec.Click += new System.EventHandler(this.btnDodajKljucnuRec_Click);
            // 
            // tbKljucnaRec
            // 
            this.tbKljucnaRec.Location = new System.Drawing.Point(512, 114);
            this.tbKljucnaRec.Margin = new System.Windows.Forms.Padding(4);
            this.tbKljucnaRec.Name = "tbKljucnaRec";
            this.tbKljucnaRec.Size = new System.Drawing.Size(149, 22);
            this.tbKljucnaRec.TabIndex = 36;
            // 
            // cbVidljivost
            // 
            this.cbVidljivost.AutoSize = true;
            this.cbVidljivost.Location = new System.Drawing.Point(512, 76);
            this.cbVidljivost.Margin = new System.Windows.Forms.Padding(4);
            this.cbVidljivost.Name = "cbVidljivost";
            this.cbVidljivost.Size = new System.Drawing.Size(62, 20);
            this.cbVidljivost.TabIndex = 35;
            this.cbVidljivost.Text = "Vidljiv";
            this.cbVidljivost.UseVisualStyleBackColor = true;
            // 
            // comboBStatus
            // 
            this.comboBStatus.FormattingEnabled = true;
            this.comboBStatus.Location = new System.Drawing.Point(512, 36);
            this.comboBStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBStatus.Name = "comboBStatus";
            this.comboBStatus.Size = new System.Drawing.Size(270, 24);
            this.comboBStatus.TabIndex = 34;
            // 
            // dtpDatumObjavljivanja
            // 
            this.dtpDatumObjavljivanja.Location = new System.Drawing.Point(150, 154);
            this.dtpDatumObjavljivanja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumObjavljivanja.Name = "dtpDatumObjavljivanja";
            this.dtpDatumObjavljivanja.Size = new System.Drawing.Size(241, 22);
            this.dtpDatumObjavljivanja.TabIndex = 33;
            // 
            // dtpDatumKreiranja
            // 
            this.dtpDatumKreiranja.Location = new System.Drawing.Point(150, 118);
            this.dtpDatumKreiranja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumKreiranja.Name = "dtpDatumKreiranja";
            this.dtpDatumKreiranja.Size = new System.Drawing.Size(241, 22);
            this.dtpDatumKreiranja.TabIndex = 32;
            // 
            // tbApstrakt
            // 
            this.tbApstrakt.Location = new System.Drawing.Point(121, 76);
            this.tbApstrakt.Margin = new System.Windows.Forms.Padding(4);
            this.tbApstrakt.Name = "tbApstrakt";
            this.tbApstrakt.Size = new System.Drawing.Size(270, 22);
            this.tbApstrakt.TabIndex = 31;
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(121, 38);
            this.tbNaslov.Margin = new System.Windows.Forms.Padding(4);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(270, 22);
            this.tbNaslov.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Verzija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Kljucna rec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Vidljivost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Datum objavljivanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Datum kreiranja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apstrakt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Naslov";
            // 
            // gbObrisi
            // 
            this.gbObrisi.Controls.Add(this.btnObrisi);
            this.gbObrisi.Controls.Add(this.btnIzmeni);
            this.gbObrisi.Controls.Add(this.comboBIstrazivackiRezultat);
            this.gbObrisi.Controls.Add(this.label10);
            this.gbObrisi.Location = new System.Drawing.Point(13, 25);
            this.gbObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.gbObrisi.Name = "gbObrisi";
            this.gbObrisi.Padding = new System.Windows.Forms.Padding(4);
            this.gbObrisi.Size = new System.Drawing.Size(1019, 79);
            this.gbObrisi.TabIndex = 64;
            this.gbObrisi.TabStop = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi.Location = new System.Drawing.Point(846, 25);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(135, 26);
            this.btnObrisi.TabIndex = 62;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeni.Location = new System.Drawing.Point(689, 25);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(135, 26);
            this.btnIzmeni.TabIndex = 61;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // comboBIstrazivackiRezultat
            // 
            this.comboBIstrazivackiRezultat.FormattingEnabled = true;
            this.comboBIstrazivackiRezultat.Location = new System.Drawing.Point(174, 25);
            this.comboBIstrazivackiRezultat.Margin = new System.Windows.Forms.Padding(4);
            this.comboBIstrazivackiRezultat.Name = "comboBIstrazivackiRezultat";
            this.comboBIstrazivackiRezultat.Size = new System.Drawing.Size(487, 24);
            this.comboBIstrazivackiRezultat.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Istrazivacki rezultat";
            // 
            // gbAzuriraj
            // 
            this.gbAzuriraj.Controls.Add(this.btnObrisiVerziju);
            this.gbAzuriraj.Controls.Add(this.btnObrisiKljucnuRec);
            this.gbAzuriraj.Controls.Add(this.btnPredjiNaPodklasu);
            this.gbAzuriraj.Controls.Add(this.btnDodajVerziju);
            this.gbAzuriraj.Controls.Add(this.btnDodajKljucnuRec);
            this.gbAzuriraj.Controls.Add(this.tbKljucnaRec);
            this.gbAzuriraj.Controls.Add(this.cbVidljivost);
            this.gbAzuriraj.Controls.Add(this.comboBStatus);
            this.gbAzuriraj.Controls.Add(this.dtpDatumObjavljivanja);
            this.gbAzuriraj.Controls.Add(this.dtpDatumKreiranja);
            this.gbAzuriraj.Controls.Add(this.tbApstrakt);
            this.gbAzuriraj.Controls.Add(this.tbNaslov);
            this.gbAzuriraj.Controls.Add(this.label8);
            this.gbAzuriraj.Controls.Add(this.label7);
            this.gbAzuriraj.Controls.Add(this.label6);
            this.gbAzuriraj.Controls.Add(this.label5);
            this.gbAzuriraj.Controls.Add(this.label4);
            this.gbAzuriraj.Controls.Add(this.label3);
            this.gbAzuriraj.Controls.Add(this.label2);
            this.gbAzuriraj.Controls.Add(this.label1);
            this.gbAzuriraj.Enabled = false;
            this.gbAzuriraj.Location = new System.Drawing.Point(13, 112);
            this.gbAzuriraj.Margin = new System.Windows.Forms.Padding(4);
            this.gbAzuriraj.Name = "gbAzuriraj";
            this.gbAzuriraj.Padding = new System.Windows.Forms.Padding(4);
            this.gbAzuriraj.Size = new System.Drawing.Size(1016, 267);
            this.gbAzuriraj.TabIndex = 65;
            this.gbAzuriraj.TabStop = false;
            // 
            // btnObrisiVerziju
            // 
            this.btnObrisiVerziju.Location = new System.Drawing.Point(689, 150);
            this.btnObrisiVerziju.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiVerziju.Name = "btnObrisiVerziju";
            this.btnObrisiVerziju.Size = new System.Drawing.Size(135, 26);
            this.btnObrisiVerziju.TabIndex = 43;
            this.btnObrisiVerziju.Text = "Obrisi verziju";
            this.btnObrisiVerziju.UseVisualStyleBackColor = true;
            this.btnObrisiVerziju.Click += new System.EventHandler(this.btnObrisiVerziju_Click);
            // 
            // btnObrisiKljucnuRec
            // 
            this.btnObrisiKljucnuRec.Location = new System.Drawing.Point(846, 110);
            this.btnObrisiKljucnuRec.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiKljucnuRec.Name = "btnObrisiKljucnuRec";
            this.btnObrisiKljucnuRec.Size = new System.Drawing.Size(135, 26);
            this.btnObrisiKljucnuRec.TabIndex = 42;
            this.btnObrisiKljucnuRec.Text = "Obrisi kljucnu rec";
            this.btnObrisiKljucnuRec.UseVisualStyleBackColor = true;
            this.btnObrisiKljucnuRec.Click += new System.EventHandler(this.btnObrisiKljucnuRec_Click);
            // 
            // FormIzmeniIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 407);
            this.Controls.Add(this.gbAzuriraj);
            this.Controls.Add(this.gbObrisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIzmeniIR";
            this.Text = "Izmene istrazivackog rezultata";
            this.gbObrisi.ResumeLayout(false);
            this.gbObrisi.PerformLayout();
            this.gbAzuriraj.ResumeLayout(false);
            this.gbAzuriraj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPredjiNaPodklasu;
        private System.Windows.Forms.Button btnDodajVerziju;
        private System.Windows.Forms.Button btnDodajKljucnuRec;
        private System.Windows.Forms.TextBox tbKljucnaRec;
        private System.Windows.Forms.CheckBox cbVidljivost;
        private System.Windows.Forms.ComboBox comboBStatus;
        private System.Windows.Forms.DateTimePicker dtpDatumObjavljivanja;
        private System.Windows.Forms.DateTimePicker dtpDatumKreiranja;
        private System.Windows.Forms.TextBox tbApstrakt;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbObrisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox comboBIstrazivackiRezultat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAzuriraj;
        private System.Windows.Forms.Button btnObrisiVerziju;
        private System.Windows.Forms.Button btnObrisiKljucnuRec;
    }
}