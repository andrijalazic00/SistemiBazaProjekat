namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniRunduRecenzije
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
            this.comboBRundaRecenzije = new System.Windows.Forms.ComboBox();
            this.btnObrisiRundu = new System.Windows.Forms.Button();
            this.btnIzmeniRundu = new System.Windows.Forms.Button();
            this.comboBKonacnaOdluka = new System.Windows.Forms.ComboBox();
            this.comboBAngazovanUrednik = new System.Windows.Forms.ComboBox();
            this.dtpDatumOdluke = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDatumOdluke = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbIzmene = new System.Windows.Forms.GroupBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.gbIzmene.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Runda recenzije za izmenu/brisanje";
            // 
            // comboBRundaRecenzije
            // 
            this.comboBRundaRecenzije.FormattingEnabled = true;
            this.comboBRundaRecenzije.Location = new System.Drawing.Point(211, 18);
            this.comboBRundaRecenzije.Name = "comboBRundaRecenzije";
            this.comboBRundaRecenzije.Size = new System.Drawing.Size(398, 21);
            this.comboBRundaRecenzije.TabIndex = 1;
            // 
            // btnObrisiRundu
            // 
            this.btnObrisiRundu.Location = new System.Drawing.Point(33, 52);
            this.btnObrisiRundu.Name = "btnObrisiRundu";
            this.btnObrisiRundu.Size = new System.Drawing.Size(220, 23);
            this.btnObrisiRundu.TabIndex = 2;
            this.btnObrisiRundu.Text = "Obrisi rundu recenzije";
            this.btnObrisiRundu.UseVisualStyleBackColor = true;
            this.btnObrisiRundu.Click += new System.EventHandler(this.btnObrisiRundu_Click);
            // 
            // btnIzmeniRundu
            // 
            this.btnIzmeniRundu.Location = new System.Drawing.Point(259, 52);
            this.btnIzmeniRundu.Name = "btnIzmeniRundu";
            this.btnIzmeniRundu.Size = new System.Drawing.Size(216, 23);
            this.btnIzmeniRundu.TabIndex = 3;
            this.btnIzmeniRundu.Text = "Izmeni rundu recenzije";
            this.btnIzmeniRundu.UseVisualStyleBackColor = true;
            this.btnIzmeniRundu.Click += new System.EventHandler(this.btnIzmeniRundu_Click);
            // 
            // comboBKonacnaOdluka
            // 
            this.comboBKonacnaOdluka.FormattingEnabled = true;
            this.comboBKonacnaOdluka.Location = new System.Drawing.Point(182, 60);
            this.comboBKonacnaOdluka.Name = "comboBKonacnaOdluka";
            this.comboBKonacnaOdluka.Size = new System.Drawing.Size(206, 21);
            this.comboBKonacnaOdluka.TabIndex = 23;
            // 
            // comboBAngazovanUrednik
            // 
            this.comboBAngazovanUrednik.FormattingEnabled = true;
            this.comboBAngazovanUrednik.Location = new System.Drawing.Point(181, 142);
            this.comboBAngazovanUrednik.Name = "comboBAngazovanUrednik";
            this.comboBAngazovanUrednik.Size = new System.Drawing.Size(207, 21);
            this.comboBAngazovanUrednik.TabIndex = 22;
            // 
            // dtpDatumOdluke
            // 
            this.dtpDatumOdluke.Location = new System.Drawing.Point(181, 105);
            this.dtpDatumOdluke.Name = "dtpDatumOdluke";
            this.dtpDatumOdluke.Size = new System.Drawing.Size(207, 20);
            this.dtpDatumOdluke.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Konacna odluka";
            // 
            // lblDatumOdluke
            // 
            this.lblDatumOdluke.AutoSize = true;
            this.lblDatumOdluke.Location = new System.Drawing.Point(79, 111);
            this.lblDatumOdluke.Name = "lblDatumOdluke";
            this.lblDatumOdluke.Size = new System.Drawing.Size(73, 13);
            this.lblDatumOdluke.TabIndex = 19;
            this.lblDatumOdluke.Text = "Datum odluke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Angazovan urednik";
            // 
            // gbIzmene
            // 
            this.gbIzmene.Controls.Add(this.btnSacuvajIzmene);
            this.gbIzmene.Controls.Add(this.comboBKonacnaOdluka);
            this.gbIzmene.Controls.Add(this.comboBAngazovanUrednik);
            this.gbIzmene.Controls.Add(this.dtpDatumOdluke);
            this.gbIzmene.Controls.Add(this.label8);
            this.gbIzmene.Controls.Add(this.lblDatumOdluke);
            this.gbIzmene.Controls.Add(this.label3);
            this.gbIzmene.Location = new System.Drawing.Point(30, 81);
            this.gbIzmene.Name = "gbIzmene";
            this.gbIzmene.Size = new System.Drawing.Size(444, 213);
            this.gbIzmene.TabIndex = 24;
            this.gbIzmene.TabStop = false;
            this.gbIzmene.Visible = false;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(87, 175);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(282, 23);
            this.btnSacuvajIzmene.TabIndex = 24;
            this.btnSacuvajIzmene.Text = "Sacuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // FormIzmeniRunduRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 402);
            this.Controls.Add(this.gbIzmene);
            this.Controls.Add(this.btnIzmeniRundu);
            this.Controls.Add(this.btnObrisiRundu);
            this.Controls.Add(this.comboBRundaRecenzije);
            this.Controls.Add(this.label1);
            this.Name = "FormIzmeniRunduRecenzije";
            this.Text = "FormIzmeniRunduRecenzije";
            this.gbIzmene.ResumeLayout(false);
            this.gbIzmene.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBRundaRecenzije;
        private System.Windows.Forms.Button btnObrisiRundu;
        private System.Windows.Forms.Button btnIzmeniRundu;
        private System.Windows.Forms.ComboBox comboBKonacnaOdluka;
        private System.Windows.Forms.ComboBox comboBAngazovanUrednik;
        private System.Windows.Forms.DateTimePicker dtpDatumOdluke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDatumOdluke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbIzmene;
        private System.Windows.Forms.Button btnSacuvajIzmene;
    }
}