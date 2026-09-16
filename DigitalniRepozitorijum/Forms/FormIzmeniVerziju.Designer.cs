namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniVerziju
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
            this.btnSacuvajVerziju = new System.Windows.Forms.Button();
            this.btnDodajFajl = new System.Windows.Forms.Button();
            this.tbNazivFajla = new System.Windows.Forms.TextBox();
            this.tbOdgovornaOsoba = new System.Windows.Forms.TextBox();
            this.tbOpisIzmena = new System.Windows.Forms.TextBox();
            this.dtpDatumPostavljanja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiFajl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSacuvajVerziju
            // 
            this.btnSacuvajVerziju.Location = new System.Drawing.Point(186, 327);
            this.btnSacuvajVerziju.Name = "btnSacuvajVerziju";
            this.btnSacuvajVerziju.Size = new System.Drawing.Size(173, 37);
            this.btnSacuvajVerziju.TabIndex = 23;
            this.btnSacuvajVerziju.Text = "Sacuvaj promene";
            this.btnSacuvajVerziju.UseVisualStyleBackColor = true;
            this.btnSacuvajVerziju.Click += new System.EventHandler(this.btnSacuvajVerziju_Click);
            // 
            // btnDodajFajl
            // 
            this.btnDodajFajl.Location = new System.Drawing.Point(550, 264);
            this.btnDodajFajl.Name = "btnDodajFajl";
            this.btnDodajFajl.Size = new System.Drawing.Size(119, 20);
            this.btnDodajFajl.TabIndex = 22;
            this.btnDodajFajl.Text = "Dodaj fajl";
            this.btnDodajFajl.UseVisualStyleBackColor = true;
            this.btnDodajFajl.Click += new System.EventHandler(this.btnDodajFajl_Click);
            // 
            // tbNazivFajla
            // 
            this.tbNazivFajla.Location = new System.Drawing.Point(282, 264);
            this.tbNazivFajla.Name = "tbNazivFajla";
            this.tbNazivFajla.Size = new System.Drawing.Size(236, 20);
            this.tbNazivFajla.TabIndex = 21;
            // 
            // tbOdgovornaOsoba
            // 
            this.tbOdgovornaOsoba.Location = new System.Drawing.Point(282, 220);
            this.tbOdgovornaOsoba.Name = "tbOdgovornaOsoba";
            this.tbOdgovornaOsoba.Size = new System.Drawing.Size(236, 20);
            this.tbOdgovornaOsoba.TabIndex = 20;
            // 
            // tbOpisIzmena
            // 
            this.tbOpisIzmena.Location = new System.Drawing.Point(282, 172);
            this.tbOpisIzmena.Name = "tbOpisIzmena";
            this.tbOpisIzmena.Size = new System.Drawing.Size(236, 20);
            this.tbOpisIzmena.TabIndex = 19;
            // 
            // dtpDatumPostavljanja
            // 
            this.dtpDatumPostavljanja.Location = new System.Drawing.Point(287, 123);
            this.dtpDatumPostavljanja.Name = "dtpDatumPostavljanja";
            this.dtpDatumPostavljanja.Size = new System.Drawing.Size(231, 20);
            this.dtpDatumPostavljanja.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Naziv fajla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odgovorna osoba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Opis izmena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum postavljanja";
            // 
            // btnObrisiFajl
            // 
            this.btnObrisiFajl.Location = new System.Drawing.Point(685, 264);
            this.btnObrisiFajl.Name = "btnObrisiFajl";
            this.btnObrisiFajl.Size = new System.Drawing.Size(103, 20);
            this.btnObrisiFajl.TabIndex = 24;
            this.btnObrisiFajl.Text = "Obrisi fajl";
            this.btnObrisiFajl.UseVisualStyleBackColor = true;
            this.btnObrisiFajl.Click += new System.EventHandler(this.btnObrisiFajl_Click);
            // 
            // FormIzmeniVerziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiFajl);
            this.Controls.Add(this.btnSacuvajVerziju);
            this.Controls.Add(this.btnDodajFajl);
            this.Controls.Add(this.tbNazivFajla);
            this.Controls.Add(this.tbOdgovornaOsoba);
            this.Controls.Add(this.tbOpisIzmena);
            this.Controls.Add(this.dtpDatumPostavljanja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormIzmeniVerziju";
            this.Text = "FormIzmeniVerziju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvajVerziju;
        private System.Windows.Forms.Button btnDodajFajl;
        private System.Windows.Forms.TextBox tbNazivFajla;
        private System.Windows.Forms.TextBox tbOdgovornaOsoba;
        private System.Windows.Forms.TextBox tbOpisIzmena;
        private System.Windows.Forms.DateTimePicker dtpDatumPostavljanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiFajl;
    }
}