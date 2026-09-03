namespace DigitalniRepozitorijum
{
    partial class FormDodajNII
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
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbNaucnaOblast = new System.Windows.Forms.TextBox();
            this.btnDodajTelefon = new System.Windows.Forms.Button();
            this.btnDodajMail = new System.Windows.Forms.Button();
            this.btnDodajNaucnuOblast = new System.Windows.Forms.Button();
            this.btnDodajNII = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naucna oblast";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(179, 23);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(102, 20);
            this.tbNaziv.TabIndex = 5;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(178, 74);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(103, 20);
            this.tbAdresa.TabIndex = 6;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(179, 132);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(105, 20);
            this.tbTelefon.TabIndex = 7;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(178, 192);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(114, 20);
            this.tbMail.TabIndex = 8;
            // 
            // tbNaucnaOblast
            // 
            this.tbNaucnaOblast.Location = new System.Drawing.Point(178, 251);
            this.tbNaucnaOblast.Name = "tbNaucnaOblast";
            this.tbNaucnaOblast.Size = new System.Drawing.Size(118, 20);
            this.tbNaucnaOblast.TabIndex = 9;
            // 
            // btnDodajTelefon
            // 
            this.btnDodajTelefon.Location = new System.Drawing.Point(335, 135);
            this.btnDodajTelefon.Name = "btnDodajTelefon";
            this.btnDodajTelefon.Size = new System.Drawing.Size(110, 23);
            this.btnDodajTelefon.TabIndex = 10;
            this.btnDodajTelefon.Text = "Dodaj telefon";
            this.btnDodajTelefon.UseVisualStyleBackColor = true;
            this.btnDodajTelefon.Click += new System.EventHandler(this.btnDodajTelefon_Click);
            // 
            // btnDodajMail
            // 
            this.btnDodajMail.Location = new System.Drawing.Point(335, 192);
            this.btnDodajMail.Name = "btnDodajMail";
            this.btnDodajMail.Size = new System.Drawing.Size(91, 29);
            this.btnDodajMail.TabIndex = 11;
            this.btnDodajMail.Text = "Dodaj mail";
            this.btnDodajMail.UseVisualStyleBackColor = true;
            this.btnDodajMail.Click += new System.EventHandler(this.btnDodajMail_Click);
            // 
            // btnDodajNaucnuOblast
            // 
            this.btnDodajNaucnuOblast.Location = new System.Drawing.Point(335, 251);
            this.btnDodajNaucnuOblast.Name = "btnDodajNaucnuOblast";
            this.btnDodajNaucnuOblast.Size = new System.Drawing.Size(127, 30);
            this.btnDodajNaucnuOblast.TabIndex = 12;
            this.btnDodajNaucnuOblast.Text = "Dodaj naucnu oblast";
            this.btnDodajNaucnuOblast.UseVisualStyleBackColor = true;
            this.btnDodajNaucnuOblast.Click += new System.EventHandler(this.btnDodajNaucnuOblast_Click);
            // 
            // btnDodajNII
            // 
            this.btnDodajNII.Location = new System.Drawing.Point(130, 334);
            this.btnDodajNII.Name = "btnDodajNII";
            this.btnDodajNII.Size = new System.Drawing.Size(225, 33);
            this.btnDodajNII.TabIndex = 13;
            this.btnDodajNII.Text = "Dodaj naucno istrazivacku instituciju";
            this.btnDodajNII.UseVisualStyleBackColor = true;
            this.btnDodajNII.Click += new System.EventHandler(this.btnDodajNII_Click);
            // 
            // FormDodajNII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajNII);
            this.Controls.Add(this.btnDodajNaucnuOblast);
            this.Controls.Add(this.btnDodajMail);
            this.Controls.Add(this.btnDodajTelefon);
            this.Controls.Add(this.tbNaucnaOblast);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajNII";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbNaucnaOblast;
        private System.Windows.Forms.Button btnDodajTelefon;
        private System.Windows.Forms.Button btnDodajMail;
        private System.Windows.Forms.Button btnDodajNaucnuOblast;
        private System.Windows.Forms.Button btnDodajNII;
    }
}