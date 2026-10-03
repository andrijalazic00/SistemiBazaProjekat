namespace DigitalniRepozitorijum.Forms
{
    partial class FormDodajRunduRecenzije
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
            this.nudBrojRunde = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumOdluke = new System.Windows.Forms.DateTimePicker();
            this.comboBAngazovanUrednik = new System.Windows.Forms.ComboBox();
            this.comboBAngazovanRecenzent = new System.Windows.Forms.ComboBox();
            this.nudOcena = new System.Windows.Forms.NumericUpDown();
            this.cbPreporuka = new System.Windows.Forms.CheckBox();
            this.comboBKonacnaOdluka = new System.Windows.Forms.ComboBox();
            this.btnDodajOcenu = new System.Windows.Forms.Button();
            this.btnDodajRecenzenta = new System.Windows.Forms.Button();
            this.btnSacuvajRunduRecenzije = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBPublikacija = new System.Windows.Forms.ComboBox();
            this.btnIzaberiPublikaciju = new System.Windows.Forms.Button();
            this.gbKontrole = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojRunde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).BeginInit();
            this.gbKontrole.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj runde recenzije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angazovan recenzent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angazovan urednik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preporuka";
            // 
            // nudBrojRunde
            // 
            this.nudBrojRunde.Location = new System.Drawing.Point(195, 23);
            this.nudBrojRunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudBrojRunde.Name = "nudBrojRunde";
            this.nudBrojRunde.Size = new System.Drawing.Size(292, 22);
            this.nudBrojRunde.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datum odluke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Konacna odluka";
            // 
            // dtpDatumOdluke
            // 
            this.dtpDatumOdluke.Location = new System.Drawing.Point(195, 103);
            this.dtpDatumOdluke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDatumOdluke.Name = "dtpDatumOdluke";
            this.dtpDatumOdluke.Size = new System.Drawing.Size(292, 22);
            this.dtpDatumOdluke.TabIndex = 10;
            // 
            // comboBAngazovanUrednik
            // 
            this.comboBAngazovanUrednik.FormattingEnabled = true;
            this.comboBAngazovanUrednik.Location = new System.Drawing.Point(195, 146);
            this.comboBAngazovanUrednik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBAngazovanUrednik.Name = "comboBAngazovanUrednik";
            this.comboBAngazovanUrednik.Size = new System.Drawing.Size(292, 24);
            this.comboBAngazovanUrednik.TabIndex = 11;
            // 
            // comboBAngazovanRecenzent
            // 
            this.comboBAngazovanRecenzent.FormattingEnabled = true;
            this.comboBAngazovanRecenzent.Location = new System.Drawing.Point(691, 23);
            this.comboBAngazovanRecenzent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBAngazovanRecenzent.Name = "comboBAngazovanRecenzent";
            this.comboBAngazovanRecenzent.Size = new System.Drawing.Size(310, 24);
            this.comboBAngazovanRecenzent.TabIndex = 12;
            // 
            // nudOcena
            // 
            this.nudOcena.Location = new System.Drawing.Point(627, 62);
            this.nudOcena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudOcena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcena.Name = "nudOcena";
            this.nudOcena.Size = new System.Drawing.Size(203, 22);
            this.nudOcena.TabIndex = 13;
            this.nudOcena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPreporuka
            // 
            this.cbPreporuka.AutoSize = true;
            this.cbPreporuka.Location = new System.Drawing.Point(627, 107);
            this.cbPreporuka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPreporuka.Name = "cbPreporuka";
            this.cbPreporuka.Size = new System.Drawing.Size(44, 20);
            this.cbPreporuka.TabIndex = 14;
            this.cbPreporuka.Text = "Da";
            this.cbPreporuka.UseVisualStyleBackColor = true;
            // 
            // comboBKonacnaOdluka
            // 
            this.comboBKonacnaOdluka.FormattingEnabled = true;
            this.comboBKonacnaOdluka.Location = new System.Drawing.Point(195, 59);
            this.comboBKonacnaOdluka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBKonacnaOdluka.Name = "comboBKonacnaOdluka";
            this.comboBKonacnaOdluka.Size = new System.Drawing.Size(292, 24);
            this.comboBKonacnaOdluka.TabIndex = 15;
            // 
            // btnDodajOcenu
            // 
            this.btnDodajOcenu.Location = new System.Drawing.Point(853, 56);
            this.btnDodajOcenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajOcenu.Name = "btnDodajOcenu";
            this.btnDodajOcenu.Size = new System.Drawing.Size(148, 28);
            this.btnDodajOcenu.TabIndex = 16;
            this.btnDodajOcenu.Text = "Dodaj ocenu";
            this.btnDodajOcenu.UseVisualStyleBackColor = true;
            this.btnDodajOcenu.Click += new System.EventHandler(this.btnDodajOcenu_Click);
            // 
            // btnDodajRecenzenta
            // 
            this.btnDodajRecenzenta.Location = new System.Drawing.Point(538, 146);
            this.btnDodajRecenzenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajRecenzenta.Name = "btnDodajRecenzenta";
            this.btnDodajRecenzenta.Size = new System.Drawing.Size(249, 24);
            this.btnDodajRecenzenta.TabIndex = 17;
            this.btnDodajRecenzenta.Text = "Dodaj recenzenta";
            this.btnDodajRecenzenta.UseVisualStyleBackColor = true;
            this.btnDodajRecenzenta.Click += new System.EventHandler(this.btnDodajRecenzenta_Click);
            // 
            // btnSacuvajRunduRecenzije
            // 
            this.btnSacuvajRunduRecenzije.Location = new System.Drawing.Point(316, 217);
            this.btnSacuvajRunduRecenzije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvajRunduRecenzije.Name = "btnSacuvajRunduRecenzije";
            this.btnSacuvajRunduRecenzije.Size = new System.Drawing.Size(375, 47);
            this.btnSacuvajRunduRecenzije.TabIndex = 18;
            this.btnSacuvajRunduRecenzije.Text = "Sacuvaj rundu recenzije";
            this.btnSacuvajRunduRecenzije.UseVisualStyleBackColor = true;
            this.btnSacuvajRunduRecenzije.Click += new System.EventHandler(this.btnSacuvajRunduRecenzije_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Publikacija";
            // 
            // comboBPublikacija
            // 
            this.comboBPublikacija.FormattingEnabled = true;
            this.comboBPublikacija.Location = new System.Drawing.Point(318, 30);
            this.comboBPublikacija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBPublikacija.Name = "comboBPublikacija";
            this.comboBPublikacija.Size = new System.Drawing.Size(313, 24);
            this.comboBPublikacija.TabIndex = 20;
            // 
            // btnIzaberiPublikaciju
            // 
            this.btnIzaberiPublikaciju.Location = new System.Drawing.Point(656, 30);
            this.btnIzaberiPublikaciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzaberiPublikaciju.Name = "btnIzaberiPublikaciju";
            this.btnIzaberiPublikaciju.Size = new System.Drawing.Size(179, 26);
            this.btnIzaberiPublikaciju.TabIndex = 21;
            this.btnIzaberiPublikaciju.Text = "Izaberi publikaciju";
            this.btnIzaberiPublikaciju.UseVisualStyleBackColor = true;
            this.btnIzaberiPublikaciju.Click += new System.EventHandler(this.btnIzaberiPublikaciju_Click);
            // 
            // gbKontrole
            // 
            this.gbKontrole.Controls.Add(this.btnSacuvajRunduRecenzije);
            this.gbKontrole.Controls.Add(this.btnDodajRecenzenta);
            this.gbKontrole.Controls.Add(this.btnDodajOcenu);
            this.gbKontrole.Controls.Add(this.comboBKonacnaOdluka);
            this.gbKontrole.Controls.Add(this.cbPreporuka);
            this.gbKontrole.Controls.Add(this.nudOcena);
            this.gbKontrole.Controls.Add(this.comboBAngazovanRecenzent);
            this.gbKontrole.Controls.Add(this.comboBAngazovanUrednik);
            this.gbKontrole.Controls.Add(this.dtpDatumOdluke);
            this.gbKontrole.Controls.Add(this.label8);
            this.gbKontrole.Controls.Add(this.label7);
            this.gbKontrole.Controls.Add(this.nudBrojRunde);
            this.gbKontrole.Controls.Add(this.label5);
            this.gbKontrole.Controls.Add(this.label4);
            this.gbKontrole.Controls.Add(this.label3);
            this.gbKontrole.Controls.Add(this.label2);
            this.gbKontrole.Controls.Add(this.label1);
            this.gbKontrole.Enabled = false;
            this.gbKontrole.Location = new System.Drawing.Point(26, 80);
            this.gbKontrole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKontrole.Name = "gbKontrole";
            this.gbKontrole.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKontrole.Size = new System.Drawing.Size(1013, 300);
            this.gbKontrole.TabIndex = 22;
            this.gbKontrole.TabStop = false;
            // 
            // FormDodajRunduRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 407);
            this.Controls.Add(this.gbKontrole);
            this.Controls.Add(this.btnIzaberiPublikaciju);
            this.Controls.Add(this.comboBPublikacija);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDodajRunduRecenzije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje runde recenzije";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojRunde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcena)).EndInit();
            this.gbKontrole.ResumeLayout(false);
            this.gbKontrole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBrojRunde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumOdluke;
        private System.Windows.Forms.ComboBox comboBAngazovanUrednik;
        private System.Windows.Forms.ComboBox comboBAngazovanRecenzent;
        private System.Windows.Forms.NumericUpDown nudOcena;
        private System.Windows.Forms.CheckBox cbPreporuka;
        private System.Windows.Forms.ComboBox comboBKonacnaOdluka;
        private System.Windows.Forms.Button btnDodajOcenu;
        private System.Windows.Forms.Button btnDodajRecenzenta;
        private System.Windows.Forms.Button btnSacuvajRunduRecenzije;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBPublikacija;
        private System.Windows.Forms.Button btnIzaberiPublikaciju;
        private System.Windows.Forms.GroupBox gbKontrole;
    }
}