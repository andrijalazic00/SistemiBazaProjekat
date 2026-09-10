namespace DigitalniRepozitorijum.Forms
{
    partial class FormDodajPublikaciju
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
            this.comboBAutor = new System.Windows.Forms.ComboBox();
            this.nudRedniBrojAutora = new System.Windows.Forms.NumericUpDown();
            this.tbTipDoprinosa = new System.Windows.Forms.TextBox();
            this.tbUlogaUPublikaciji = new System.Windows.Forms.TextBox();
            this.comboBZasnivaSeNa = new System.Windows.Forms.ComboBox();
            this.btnSacuvajPublikaciju = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBKoriscen = new System.Windows.Forms.ComboBox();
            this.comboBNastalaIz = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedniBrojAutora)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Redni broj autora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip doprinosa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Uloga u publikaciji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zasniva se na datasetu";
            // 
            // comboBAutor
            // 
            this.comboBAutor.FormattingEnabled = true;
            this.comboBAutor.Location = new System.Drawing.Point(183, 26);
            this.comboBAutor.Name = "comboBAutor";
            this.comboBAutor.Size = new System.Drawing.Size(146, 21);
            this.comboBAutor.TabIndex = 5;
            // 
            // nudRedniBrojAutora
            // 
            this.nudRedniBrojAutora.Location = new System.Drawing.Point(179, 61);
            this.nudRedniBrojAutora.Name = "nudRedniBrojAutora";
            this.nudRedniBrojAutora.Size = new System.Drawing.Size(149, 20);
            this.nudRedniBrojAutora.TabIndex = 6;
            // 
            // tbTipDoprinosa
            // 
            this.tbTipDoprinosa.Location = new System.Drawing.Point(175, 99);
            this.tbTipDoprinosa.Name = "tbTipDoprinosa";
            this.tbTipDoprinosa.Size = new System.Drawing.Size(152, 20);
            this.tbTipDoprinosa.TabIndex = 7;
            // 
            // tbUlogaUPublikaciji
            // 
            this.tbUlogaUPublikaciji.Location = new System.Drawing.Point(173, 142);
            this.tbUlogaUPublikaciji.Name = "tbUlogaUPublikaciji";
            this.tbUlogaUPublikaciji.Size = new System.Drawing.Size(153, 20);
            this.tbUlogaUPublikaciji.TabIndex = 8;
            // 
            // comboBZasnivaSeNa
            // 
            this.comboBZasnivaSeNa.FormattingEnabled = true;
            this.comboBZasnivaSeNa.Location = new System.Drawing.Point(173, 188);
            this.comboBZasnivaSeNa.Name = "comboBZasnivaSeNa";
            this.comboBZasnivaSeNa.Size = new System.Drawing.Size(153, 21);
            this.comboBZasnivaSeNa.TabIndex = 9;
            // 
            // btnSacuvajPublikaciju
            // 
            this.btnSacuvajPublikaciju.Location = new System.Drawing.Point(129, 301);
            this.btnSacuvajPublikaciju.Name = "btnSacuvajPublikaciju";
            this.btnSacuvajPublikaciju.Size = new System.Drawing.Size(197, 23);
            this.btnSacuvajPublikaciju.TabIndex = 10;
            this.btnSacuvajPublikaciju.Text = "Sacuvaj publikaciju";
            this.btnSacuvajPublikaciju.UseVisualStyleBackColor = true;
            this.btnSacuvajPublikaciju.Click += new System.EventHandler(this.btnSacuvajPublikaciju_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Koriscen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nastala iz";
            // 
            // comboBKoriscen
            // 
            this.comboBKoriscen.FormattingEnabled = true;
            this.comboBKoriscen.Location = new System.Drawing.Point(173, 219);
            this.comboBKoriscen.Name = "comboBKoriscen";
            this.comboBKoriscen.Size = new System.Drawing.Size(153, 21);
            this.comboBKoriscen.TabIndex = 13;
            // 
            // comboBNastalaIz
            // 
            this.comboBNastalaIz.FormattingEnabled = true;
            this.comboBNastalaIz.Location = new System.Drawing.Point(173, 252);
            this.comboBNastalaIz.Name = "comboBNastalaIz";
            this.comboBNastalaIz.Size = new System.Drawing.Size(152, 21);
            this.comboBNastalaIz.TabIndex = 14;
            // 
            // FormDodajPublikaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBNastalaIz);
            this.Controls.Add(this.comboBKoriscen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvajPublikaciju);
            this.Controls.Add(this.comboBZasnivaSeNa);
            this.Controls.Add(this.tbUlogaUPublikaciji);
            this.Controls.Add(this.tbTipDoprinosa);
            this.Controls.Add(this.nudRedniBrojAutora);
            this.Controls.Add(this.comboBAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajPublikaciju";
            this.Text = "FormDodajPublikaciju";
            ((System.ComponentModel.ISupportInitialize)(this.nudRedniBrojAutora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBAutor;
        private System.Windows.Forms.NumericUpDown nudRedniBrojAutora;
        private System.Windows.Forms.TextBox tbTipDoprinosa;
        private System.Windows.Forms.TextBox tbUlogaUPublikaciji;
        private System.Windows.Forms.ComboBox comboBZasnivaSeNa;
        private System.Windows.Forms.Button btnSacuvajPublikaciju;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBKoriscen;
        private System.Windows.Forms.ComboBox comboBNastalaIz;
    }
}