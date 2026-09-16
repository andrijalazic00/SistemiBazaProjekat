namespace DigitalniRepozitorijum.Forms
{
    partial class FormNaucniRad
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblBrojStranice = new System.Windows.Forms.Label();
            this.comboBTipRada = new System.Windows.Forms.ComboBox();
            this.tbNazivCasopisa = new System.Windows.Forms.TextBox();
            this.tbDOI = new System.Windows.Forms.TextBox();
            this.tbISSN = new System.Windows.Forms.TextBox();
            this.nudBrojSveske = new System.Windows.Forms.NumericUpDown();
            this.nudBrojIzdanja = new System.Windows.Forms.NumericUpDown();
            this.nudBrojStranice = new System.Windows.Forms.NumericUpDown();
            this.btnSacuvajNaucniRad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSveske)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojIzdanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojStranice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip rada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv casopisa/konferencije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISSN/ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj sveske";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Broj izdanja";
            // 
            // lblBrojStranice
            // 
            this.lblBrojStranice.AutoSize = true;
            this.lblBrojStranice.Location = new System.Drawing.Point(34, 235);
            this.lblBrojStranice.Name = "lblBrojStranice";
            this.lblBrojStranice.Size = new System.Drawing.Size(65, 13);
            this.lblBrojStranice.TabIndex = 6;
            this.lblBrojStranice.Text = "Broj stranice";
            // 
            // comboBTipRada
            // 
            this.comboBTipRada.FormattingEnabled = true;
            this.comboBTipRada.Location = new System.Drawing.Point(236, 25);
            this.comboBTipRada.Name = "comboBTipRada";
            this.comboBTipRada.Size = new System.Drawing.Size(182, 21);
            this.comboBTipRada.TabIndex = 7;
            // 
            // tbNazivCasopisa
            // 
            this.tbNazivCasopisa.Location = new System.Drawing.Point(236, 60);
            this.tbNazivCasopisa.Name = "tbNazivCasopisa";
            this.tbNazivCasopisa.Size = new System.Drawing.Size(182, 20);
            this.tbNazivCasopisa.TabIndex = 8;
            // 
            // tbDOI
            // 
            this.tbDOI.Location = new System.Drawing.Point(234, 91);
            this.tbDOI.Name = "tbDOI";
            this.tbDOI.Size = new System.Drawing.Size(183, 20);
            this.tbDOI.TabIndex = 9;
            // 
            // tbISSN
            // 
            this.tbISSN.Location = new System.Drawing.Point(235, 123);
            this.tbISSN.Name = "tbISSN";
            this.tbISSN.Size = new System.Drawing.Size(182, 20);
            this.tbISSN.TabIndex = 10;
            // 
            // nudBrojSveske
            // 
            this.nudBrojSveske.Location = new System.Drawing.Point(233, 161);
            this.nudBrojSveske.Name = "nudBrojSveske";
            this.nudBrojSveske.Size = new System.Drawing.Size(183, 20);
            this.nudBrojSveske.TabIndex = 11;
            // 
            // nudBrojIzdanja
            // 
            this.nudBrojIzdanja.Location = new System.Drawing.Point(228, 199);
            this.nudBrojIzdanja.Name = "nudBrojIzdanja";
            this.nudBrojIzdanja.Size = new System.Drawing.Size(189, 20);
            this.nudBrojIzdanja.TabIndex = 12;
            // 
            // nudBrojStranice
            // 
            this.nudBrojStranice.Location = new System.Drawing.Point(226, 234);
            this.nudBrojStranice.Name = "nudBrojStranice";
            this.nudBrojStranice.Size = new System.Drawing.Size(191, 20);
            this.nudBrojStranice.TabIndex = 13;
            // 
            // btnSacuvajNaucniRad
            // 
            this.btnSacuvajNaucniRad.Location = new System.Drawing.Point(44, 294);
            this.btnSacuvajNaucniRad.Name = "btnSacuvajNaucniRad";
            this.btnSacuvajNaucniRad.Size = new System.Drawing.Size(274, 32);
            this.btnSacuvajNaucniRad.TabIndex = 14;
            this.btnSacuvajNaucniRad.Text = "Sacuvaj naucni rad";
            this.btnSacuvajNaucniRad.UseVisualStyleBackColor = true;
            this.btnSacuvajNaucniRad.Click += new System.EventHandler(this.btnSacuvajNaucniRad_Click);
            // 
            // FormNaucniRad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajNaucniRad);
            this.Controls.Add(this.nudBrojStranice);
            this.Controls.Add(this.nudBrojIzdanja);
            this.Controls.Add(this.nudBrojSveske);
            this.Controls.Add(this.tbISSN);
            this.Controls.Add(this.tbDOI);
            this.Controls.Add(this.tbNazivCasopisa);
            this.Controls.Add(this.comboBTipRada);
            this.Controls.Add(this.lblBrojStranice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNaucniRad";
            this.Text = "FormNaucniRad";
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojSveske)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojIzdanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojStranice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBrojStranice;
        private System.Windows.Forms.ComboBox comboBTipRada;
        private System.Windows.Forms.TextBox tbNazivCasopisa;
        private System.Windows.Forms.TextBox tbDOI;
        private System.Windows.Forms.TextBox tbISSN;
        private System.Windows.Forms.NumericUpDown nudBrojSveske;
        private System.Windows.Forms.NumericUpDown nudBrojIzdanja;
        private System.Windows.Forms.NumericUpDown nudBrojStranice;
        private System.Windows.Forms.Button btnSacuvajNaucniRad;
    }
}