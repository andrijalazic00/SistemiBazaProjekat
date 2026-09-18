namespace DigitalniRepozitorijum.Forms
{
    partial class FormBrisanjeIAzuriranje
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
            this.btnIzmeniPublikaciju = new System.Windows.Forms.Button();
            this.btnObrisiUlogu = new System.Windows.Forms.Button();
            this.btnIzmeniIstrazivaca = new System.Windows.Forms.Button();
            this.btnIzmeniNII = new System.Windows.Forms.Button();
            this.btnIzmeniIstrazivackiRezultat = new System.Windows.Forms.Button();
            this.btnIzmeniAngazovanje = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIzmeniPublikaciju
            // 
            this.btnIzmeniPublikaciju.Location = new System.Drawing.Point(624, 29);
            this.btnIzmeniPublikaciju.Name = "btnIzmeniPublikaciju";
            this.btnIzmeniPublikaciju.Size = new System.Drawing.Size(144, 37);
            this.btnIzmeniPublikaciju.TabIndex = 4;
            this.btnIzmeniPublikaciju.Text = "Izmeni/obrisi publikaciju";
            this.btnIzmeniPublikaciju.UseVisualStyleBackColor = true;
            this.btnIzmeniPublikaciju.Click += new System.EventHandler(this.btnIzmeniPublikaciju_Click);
            // 
            // btnObrisiUlogu
            // 
            this.btnObrisiUlogu.Location = new System.Drawing.Point(624, 97);
            this.btnObrisiUlogu.Name = "btnObrisiUlogu";
            this.btnObrisiUlogu.Size = new System.Drawing.Size(144, 42);
            this.btnObrisiUlogu.TabIndex = 5;
            this.btnObrisiUlogu.Text = "Obrisi ulogu";
            this.btnObrisiUlogu.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniIstrazivaca
            // 
            this.btnIzmeniIstrazivaca.Location = new System.Drawing.Point(57, 29);
            this.btnIzmeniIstrazivaca.Name = "btnIzmeniIstrazivaca";
            this.btnIzmeniIstrazivaca.Size = new System.Drawing.Size(144, 37);
            this.btnIzmeniIstrazivaca.TabIndex = 6;
            this.btnIzmeniIstrazivaca.Text = "Izmeni/obrisi istrazivaca";
            this.btnIzmeniIstrazivaca.UseVisualStyleBackColor = true;
            this.btnIzmeniIstrazivaca.Click += new System.EventHandler(this.btnIzmeniIstrazivaca_Click);
            // 
            // btnIzmeniNII
            // 
            this.btnIzmeniNII.Location = new System.Drawing.Point(257, 29);
            this.btnIzmeniNII.Name = "btnIzmeniNII";
            this.btnIzmeniNII.Size = new System.Drawing.Size(144, 37);
            this.btnIzmeniNII.TabIndex = 7;
            this.btnIzmeniNII.Text = "Izmeni/obrisi NII";
            this.btnIzmeniNII.UseVisualStyleBackColor = true;
            this.btnIzmeniNII.Click += new System.EventHandler(this.btnIzmeniNII_Click);
            // 
            // btnIzmeniIstrazivackiRezultat
            // 
            this.btnIzmeniIstrazivackiRezultat.Location = new System.Drawing.Point(447, 29);
            this.btnIzmeniIstrazivackiRezultat.Name = "btnIzmeniIstrazivackiRezultat";
            this.btnIzmeniIstrazivackiRezultat.Size = new System.Drawing.Size(144, 37);
            this.btnIzmeniIstrazivackiRezultat.TabIndex = 8;
            this.btnIzmeniIstrazivackiRezultat.Text = "Izmeni/obrisi istrazivacki rezultat";
            this.btnIzmeniIstrazivackiRezultat.UseVisualStyleBackColor = true;
            this.btnIzmeniIstrazivackiRezultat.Click += new System.EventHandler(this.btnIzmeniIstrazivackiRezultat_Click);
            // 
            // btnIzmeniAngazovanje
            // 
            this.btnIzmeniAngazovanje.Location = new System.Drawing.Point(57, 97);
            this.btnIzmeniAngazovanje.Name = "btnIzmeniAngazovanje";
            this.btnIzmeniAngazovanje.Size = new System.Drawing.Size(144, 42);
            this.btnIzmeniAngazovanje.TabIndex = 9;
            this.btnIzmeniAngazovanje.Text = "Izmeni/Obrisi angazovanje";
            this.btnIzmeniAngazovanje.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(257, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 42);
            this.button7.TabIndex = 10;
            this.button7.Text = "Izmeni/obrisi citat";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(447, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 42);
            this.button8.TabIndex = 11;
            this.button8.Text = "Izmeni/obrisi rundu recenzije";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FormBrisanjeIAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 183);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnIzmeniAngazovanje);
            this.Controls.Add(this.btnIzmeniIstrazivackiRezultat);
            this.Controls.Add(this.btnIzmeniNII);
            this.Controls.Add(this.btnIzmeniIstrazivaca);
            this.Controls.Add(this.btnObrisiUlogu);
            this.Controls.Add(this.btnIzmeniPublikaciju);
            this.Name = "FormBrisanjeIAzuriranje";
            this.Text = "FormBrisanjeIAzuriranje";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeniPublikaciju;
        private System.Windows.Forms.Button btnObrisiUlogu;
        private System.Windows.Forms.Button btnIzmeniIstrazivaca;
        private System.Windows.Forms.Button btnIzmeniNII;
        private System.Windows.Forms.Button btnIzmeniIstrazivackiRezultat;
        private System.Windows.Forms.Button btnIzmeniAngazovanje;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}