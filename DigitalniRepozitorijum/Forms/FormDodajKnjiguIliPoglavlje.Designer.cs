namespace DigitalniRepozitorijum.Forms
{
    partial class FormDodajKnjiguIliPoglavlje
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
            this.comboBUrednici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajUrednika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izdavac";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesto izdavanja";
            // 
            // tbIzdavac
            // 
            this.tbIzdavac.Location = new System.Drawing.Point(173, 47);
            this.tbIzdavac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIzdavac.Name = "tbIzdavac";
            this.tbIzdavac.Size = new System.Drawing.Size(295, 22);
            this.tbIzdavac.TabIndex = 2;
            // 
            // tbMestoIzdavanja
            // 
            this.tbMestoIzdavanja.Location = new System.Drawing.Point(173, 77);
            this.tbMestoIzdavanja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMestoIzdavanja.Name = "tbMestoIzdavanja";
            this.tbMestoIzdavanja.Size = new System.Drawing.Size(295, 22);
            this.tbMestoIzdavanja.TabIndex = 3;
            // 
            // btnSacuvajKnjigu
            // 
            this.btnSacuvajKnjigu.Location = new System.Drawing.Point(173, 155);
            this.btnSacuvajKnjigu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvajKnjigu.Name = "btnSacuvajKnjigu";
            this.btnSacuvajKnjigu.Size = new System.Drawing.Size(295, 36);
            this.btnSacuvajKnjigu.TabIndex = 4;
            this.btnSacuvajKnjigu.Text = "Sacuvaj knjigu ili poglavlje";
            this.btnSacuvajKnjigu.UseVisualStyleBackColor = true;
            this.btnSacuvajKnjigu.Click += new System.EventHandler(this.btnSacuvajKnjigu_Click);
            // 
            // comboBUrednici
            // 
            this.comboBUrednici.FormattingEnabled = true;
            this.comboBUrednici.Location = new System.Drawing.Point(173, 107);
            this.comboBUrednici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBUrednici.Name = "comboBUrednici";
            this.comboBUrednici.Size = new System.Drawing.Size(295, 24);
            this.comboBUrednici.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urednik";
            // 
            // btnDodajUrednika
            // 
            this.btnDodajUrednika.Location = new System.Drawing.Point(505, 104);
            this.btnDodajUrednika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUrednika.Name = "btnDodajUrednika";
            this.btnDodajUrednika.Size = new System.Drawing.Size(191, 27);
            this.btnDodajUrednika.TabIndex = 7;
            this.btnDodajUrednika.Text = "Dodaj urednika";
            this.btnDodajUrednika.UseVisualStyleBackColor = true;
            this.btnDodajUrednika.Click += new System.EventHandler(this.btnDodajUrednika_Click);
            // 
            // FormDodajKnjiguIliPoglavlje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 230);
            this.Controls.Add(this.btnDodajUrednika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBUrednici);
            this.Controls.Add(this.btnSacuvajKnjigu);
            this.Controls.Add(this.tbMestoIzdavanja);
            this.Controls.Add(this.tbIzdavac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDodajKnjiguIliPoglavlje";
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
        private System.Windows.Forms.ComboBox comboBUrednici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajUrednika;
    }
}