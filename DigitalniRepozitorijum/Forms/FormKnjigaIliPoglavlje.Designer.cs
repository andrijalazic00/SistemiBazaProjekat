namespace DigitalniRepozitorijum.Forms
{
    partial class FormKnjigaIliPoglavlje
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
            this.tbIzdavac = new System.Windows.Forms.TextBox();
            this.tbMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.btnSacuvajKnjigu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izdavac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto izdavanja";
            // 
            // tbIzdavac
            // 
            this.tbIzdavac.Location = new System.Drawing.Point(130, 38);
            this.tbIzdavac.Name = "tbIzdavac";
            this.tbIzdavac.Size = new System.Drawing.Size(83, 20);
            this.tbIzdavac.TabIndex = 2;
            // 
            // tbMestoIzdavanja
            // 
            this.tbMestoIzdavanja.Location = new System.Drawing.Point(127, 90);
            this.tbMestoIzdavanja.Name = "tbMestoIzdavanja";
            this.tbMestoIzdavanja.Size = new System.Drawing.Size(85, 20);
            this.tbMestoIzdavanja.TabIndex = 3;
            // 
            // btnSacuvajKnjigu
            // 
            this.btnSacuvajKnjigu.Location = new System.Drawing.Point(24, 144);
            this.btnSacuvajKnjigu.Name = "btnSacuvajKnjigu";
            this.btnSacuvajKnjigu.Size = new System.Drawing.Size(187, 37);
            this.btnSacuvajKnjigu.TabIndex = 4;
            this.btnSacuvajKnjigu.Text = "Sacuvaj knjigu ili poglavlje";
            this.btnSacuvajKnjigu.UseVisualStyleBackColor = true;
            this.btnSacuvajKnjigu.Click += new System.EventHandler(this.btnSacuvajKnjigu_Click);
            // 
            // FormKnjigaIliPoglavlje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvajKnjigu);
            this.Controls.Add(this.tbMestoIzdavanja);
            this.Controls.Add(this.tbIzdavac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKnjigaIliPoglavlje";
            this.Text = "FormKnjigaIliPoglavlje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIzdavac;
        private System.Windows.Forms.TextBox tbMestoIzdavanja;
        private System.Windows.Forms.Button btnSacuvajKnjigu;
    }
}