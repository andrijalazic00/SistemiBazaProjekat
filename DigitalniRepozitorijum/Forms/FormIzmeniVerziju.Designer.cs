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
            this.btnSacuvajVerziju.Location = new System.Drawing.Point(355, 175);
            this.btnSacuvajVerziju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvajVerziju.Name = "btnSacuvajVerziju";
            this.btnSacuvajVerziju.Size = new System.Drawing.Size(231, 37);
            this.btnSacuvajVerziju.TabIndex = 23;
            this.btnSacuvajVerziju.Text = "Sacuvaj promene";
            this.btnSacuvajVerziju.UseVisualStyleBackColor = true;
            this.btnSacuvajVerziju.Click += new System.EventHandler(this.btnSacuvajVerziju_Click);
            // 
            // btnDodajFajl
            // 
            this.btnDodajFajl.Location = new System.Drawing.Point(616, 124);
            this.btnDodajFajl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajFajl.Name = "btnDodajFajl";
            this.btnDodajFajl.Size = new System.Drawing.Size(159, 25);
            this.btnDodajFajl.TabIndex = 22;
            this.btnDodajFajl.Text = "Dodaj fajl";
            this.btnDodajFajl.UseVisualStyleBackColor = true;
            this.btnDodajFajl.Click += new System.EventHandler(this.btnDodajFajl_Click);
            // 
            // tbNazivFajla
            // 
            this.tbNazivFajla.Location = new System.Drawing.Point(273, 127);
            this.tbNazivFajla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNazivFajla.Name = "tbNazivFajla";
            this.tbNazivFajla.Size = new System.Drawing.Size(313, 22);
            this.tbNazivFajla.TabIndex = 21;
            // 
            // tbOdgovornaOsoba
            // 
            this.tbOdgovornaOsoba.Location = new System.Drawing.Point(273, 97);
            this.tbOdgovornaOsoba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOdgovornaOsoba.Name = "tbOdgovornaOsoba";
            this.tbOdgovornaOsoba.Size = new System.Drawing.Size(313, 22);
            this.tbOdgovornaOsoba.TabIndex = 20;
            // 
            // tbOpisIzmena
            // 
            this.tbOpisIzmena.Location = new System.Drawing.Point(273, 67);
            this.tbOpisIzmena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOpisIzmena.Name = "tbOpisIzmena";
            this.tbOpisIzmena.Size = new System.Drawing.Size(313, 22);
            this.tbOpisIzmena.TabIndex = 19;
            // 
            // dtpDatumPostavljanja
            // 
            this.dtpDatumPostavljanja.Location = new System.Drawing.Point(273, 37);
            this.dtpDatumPostavljanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumPostavljanja.Name = "dtpDatumPostavljanja";
            this.dtpDatumPostavljanja.Size = new System.Drawing.Size(313, 22);
            this.dtpDatumPostavljanja.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Naziv fajla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Odgovorna osoba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Opis izmena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum postavljanja";
            // 
            // btnObrisiFajl
            // 
            this.btnObrisiFajl.Location = new System.Drawing.Point(796, 124);
            this.btnObrisiFajl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiFajl.Name = "btnObrisiFajl";
            this.btnObrisiFajl.Size = new System.Drawing.Size(137, 25);
            this.btnObrisiFajl.TabIndex = 24;
            this.btnObrisiFajl.Text = "Obrisi fajl";
            this.btnObrisiFajl.UseVisualStyleBackColor = true;
            this.btnObrisiFajl.Click += new System.EventHandler(this.btnObrisiFajl_Click);
            // 
            // FormIzmeniVerziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 255);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIzmeniVerziju";
            this.Text = "Izmene verzije";
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