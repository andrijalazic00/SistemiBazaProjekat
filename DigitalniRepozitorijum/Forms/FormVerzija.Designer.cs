namespace DigitalniRepozitorijum.Forms
{
    partial class FormVerzija
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
            this.nudBrojVerzije = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumPostavljanja = new System.Windows.Forms.DateTimePicker();
            this.tbOpisIzmena = new System.Windows.Forms.TextBox();
            this.tbOdgovornaOsoba = new System.Windows.Forms.TextBox();
            this.tbNazivFajla = new System.Windows.Forms.TextBox();
            this.btnDodajFajl = new System.Windows.Forms.Button();
            this.btnSacuvajVerziju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojVerzije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj verzije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum postavljanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis izmena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odgovorna osoba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naziv fajla";
            // 
            // nudBrojVerzije
            // 
            this.nudBrojVerzije.Location = new System.Drawing.Point(198, 15);
            this.nudBrojVerzije.Name = "nudBrojVerzije";
            this.nudBrojVerzije.Size = new System.Drawing.Size(123, 20);
            this.nudBrojVerzije.TabIndex = 5;
            // 
            // dtpDatumPostavljanja
            // 
            this.dtpDatumPostavljanja.Location = new System.Drawing.Point(198, 52);
            this.dtpDatumPostavljanja.Name = "dtpDatumPostavljanja";
            this.dtpDatumPostavljanja.Size = new System.Drawing.Size(231, 20);
            this.dtpDatumPostavljanja.TabIndex = 6;
            // 
            // tbOpisIzmena
            // 
            this.tbOpisIzmena.Location = new System.Drawing.Point(193, 101);
            this.tbOpisIzmena.Name = "tbOpisIzmena";
            this.tbOpisIzmena.Size = new System.Drawing.Size(236, 20);
            this.tbOpisIzmena.TabIndex = 7;
            // 
            // tbOdgovornaOsoba
            // 
            this.tbOdgovornaOsoba.Location = new System.Drawing.Point(193, 149);
            this.tbOdgovornaOsoba.Name = "tbOdgovornaOsoba";
            this.tbOdgovornaOsoba.Size = new System.Drawing.Size(236, 20);
            this.tbOdgovornaOsoba.TabIndex = 8;
            // 
            // tbNazivFajla
            // 
            this.tbNazivFajla.Location = new System.Drawing.Point(193, 193);
            this.tbNazivFajla.Name = "tbNazivFajla";
            this.tbNazivFajla.Size = new System.Drawing.Size(236, 20);
            this.tbNazivFajla.TabIndex = 9;
            // 
            // btnDodajFajl
            // 
            this.btnDodajFajl.Location = new System.Drawing.Point(461, 193);
            this.btnDodajFajl.Name = "btnDodajFajl";
            this.btnDodajFajl.Size = new System.Drawing.Size(119, 20);
            this.btnDodajFajl.TabIndex = 10;
            this.btnDodajFajl.Text = "Dodaj fajl";
            this.btnDodajFajl.UseVisualStyleBackColor = true;
            this.btnDodajFajl.Click += new System.EventHandler(this.btnDodajFajl_Click);
            // 
            // btnSacuvajVerziju
            // 
            this.btnSacuvajVerziju.Location = new System.Drawing.Point(97, 256);
            this.btnSacuvajVerziju.Name = "btnSacuvajVerziju";
            this.btnSacuvajVerziju.Size = new System.Drawing.Size(173, 37);
            this.btnSacuvajVerziju.TabIndex = 11;
            this.btnSacuvajVerziju.Text = "Sacuvaj verziju";
            this.btnSacuvajVerziju.UseVisualStyleBackColor = true;
            this.btnSacuvajVerziju.Click += new System.EventHandler(this.btnSacuvajVerziju_Click);
            // 
            // FormVerzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajVerziju);
            this.Controls.Add(this.btnDodajFajl);
            this.Controls.Add(this.tbNazivFajla);
            this.Controls.Add(this.tbOdgovornaOsoba);
            this.Controls.Add(this.tbOpisIzmena);
            this.Controls.Add(this.dtpDatumPostavljanja);
            this.Controls.Add(this.nudBrojVerzije);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVerzija";
            this.Text = "FormVerzija";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojVerzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBrojVerzije;
        private System.Windows.Forms.DateTimePicker dtpDatumPostavljanja;
        private System.Windows.Forms.TextBox tbOpisIzmena;
        private System.Windows.Forms.TextBox tbOdgovornaOsoba;
        private System.Windows.Forms.TextBox tbNazivFajla;
        private System.Windows.Forms.Button btnDodajFajl;
        private System.Windows.Forms.Button btnSacuvajVerziju;
    }
}