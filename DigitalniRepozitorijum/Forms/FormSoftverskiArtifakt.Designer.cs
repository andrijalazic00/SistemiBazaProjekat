namespace DigitalniRepozitorijum.Forms
{
    partial class FormSoftverskiArtifakt
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
            this.tbProgramskiJezik = new System.Windows.Forms.TextBox();
            this.tbRepoLink = new System.Windows.Forms.TextBox();
            this.tbNacinLicenciranja = new System.Windows.Forms.TextBox();
            this.comboBPodrzanePlatforme = new System.Windows.Forms.ComboBox();
            this.tbDokumentacija = new System.Windows.Forms.TextBox();
            this.btnDodajPlatformu = new System.Windows.Forms.Button();
            this.btnSacuvajSoftverskiArtifakt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programski jezik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repo link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nacin licenciranja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Podrzane platforme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dokumentacija";
            // 
            // tbProgramskiJezik
            // 
            this.tbProgramskiJezik.Location = new System.Drawing.Point(156, 32);
            this.tbProgramskiJezik.Name = "tbProgramskiJezik";
            this.tbProgramskiJezik.Size = new System.Drawing.Size(109, 20);
            this.tbProgramskiJezik.TabIndex = 5;
            // 
            // tbRepoLink
            // 
            this.tbRepoLink.Location = new System.Drawing.Point(156, 70);
            this.tbRepoLink.Name = "tbRepoLink";
            this.tbRepoLink.Size = new System.Drawing.Size(113, 20);
            this.tbRepoLink.TabIndex = 6;
            // 
            // tbNacinLicenciranja
            // 
            this.tbNacinLicenciranja.Location = new System.Drawing.Point(156, 117);
            this.tbNacinLicenciranja.Name = "tbNacinLicenciranja";
            this.tbNacinLicenciranja.Size = new System.Drawing.Size(116, 20);
            this.tbNacinLicenciranja.TabIndex = 7;
            // 
            // comboBPodrzanePlatforme
            // 
            this.comboBPodrzanePlatforme.FormattingEnabled = true;
            this.comboBPodrzanePlatforme.Location = new System.Drawing.Point(156, 170);
            this.comboBPodrzanePlatforme.Name = "comboBPodrzanePlatforme";
            this.comboBPodrzanePlatforme.Size = new System.Drawing.Size(135, 21);
            this.comboBPodrzanePlatforme.TabIndex = 8;
            // 
            // tbDokumentacija
            // 
            this.tbDokumentacija.Location = new System.Drawing.Point(156, 230);
            this.tbDokumentacija.Name = "tbDokumentacija";
            this.tbDokumentacija.Size = new System.Drawing.Size(94, 20);
            this.tbDokumentacija.TabIndex = 9;
            // 
            // btnDodajPlatformu
            // 
            this.btnDodajPlatformu.Location = new System.Drawing.Point(330, 170);
            this.btnDodajPlatformu.Name = "btnDodajPlatformu";
            this.btnDodajPlatformu.Size = new System.Drawing.Size(92, 23);
            this.btnDodajPlatformu.TabIndex = 10;
            this.btnDodajPlatformu.Text = "Dodaj platformu";
            this.btnDodajPlatformu.UseVisualStyleBackColor = true;
            this.btnDodajPlatformu.Click += new System.EventHandler(this.btnDodajPlatformu_Click);
            // 
            // btnSacuvajSoftverskiArtifakt
            // 
            this.btnSacuvajSoftverskiArtifakt.Location = new System.Drawing.Point(78, 297);
            this.btnSacuvajSoftverskiArtifakt.Name = "btnSacuvajSoftverskiArtifakt";
            this.btnSacuvajSoftverskiArtifakt.Size = new System.Drawing.Size(186, 34);
            this.btnSacuvajSoftverskiArtifakt.TabIndex = 11;
            this.btnSacuvajSoftverskiArtifakt.Text = "Sacuvaj softverski artifakt";
            this.btnSacuvajSoftverskiArtifakt.UseVisualStyleBackColor = true;
            this.btnSacuvajSoftverskiArtifakt.Click += new System.EventHandler(this.btnSacuvajSoftverskiArtifakt_Click);
            // 
            // FormSoftverskiArtifakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajSoftverskiArtifakt);
            this.Controls.Add(this.btnDodajPlatformu);
            this.Controls.Add(this.tbDokumentacija);
            this.Controls.Add(this.comboBPodrzanePlatforme);
            this.Controls.Add(this.tbNacinLicenciranja);
            this.Controls.Add(this.tbRepoLink);
            this.Controls.Add(this.tbProgramskiJezik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSoftverskiArtifakt";
            this.Text = "FormSoftverskiArtefakt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProgramskiJezik;
        private System.Windows.Forms.TextBox tbRepoLink;
        private System.Windows.Forms.TextBox tbNacinLicenciranja;
        private System.Windows.Forms.ComboBox comboBPodrzanePlatforme;
        private System.Windows.Forms.TextBox tbDokumentacija;
        private System.Windows.Forms.Button btnDodajPlatformu;
        private System.Windows.Forms.Button btnSacuvajSoftverskiArtifakt;
    }
}