namespace DigitalniRepozitorijum
{
    partial class Form1
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
            this.btnDodajNII = new System.Windows.Forms.Button();
            this.btnDodajIstrazivaca = new System.Windows.Forms.Button();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.btnDodajIR = new System.Windows.Forms.Button();
            this.btnPoveziIstrazivacNII = new System.Windows.Forms.Button();
            this.btnDodajPublikaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDodajNII
            // 
            this.btnDodajNII.Location = new System.Drawing.Point(66, 47);
            this.btnDodajNII.Name = "btnDodajNII";
            this.btnDodajNII.Size = new System.Drawing.Size(210, 25);
            this.btnDodajNII.TabIndex = 0;
            this.btnDodajNII.Text = "DodajNII";
            this.btnDodajNII.UseVisualStyleBackColor = true;
            this.btnDodajNII.Click += new System.EventHandler(this.btnDodajNII_Click);
            // 
            // btnDodajIstrazivaca
            // 
            this.btnDodajIstrazivaca.Location = new System.Drawing.Point(66, 103);
            this.btnDodajIstrazivaca.Name = "btnDodajIstrazivaca";
            this.btnDodajIstrazivaca.Size = new System.Drawing.Size(209, 22);
            this.btnDodajIstrazivaca.TabIndex = 1;
            this.btnDodajIstrazivaca.Text = "Dodaj istrazivaca";
            this.btnDodajIstrazivaca.UseVisualStyleBackColor = true;
            this.btnDodajIstrazivaca.Click += new System.EventHandler(this.btnDodajIstrazivaca_Click);
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(66, 155);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(209, 22);
            this.btnDodajUlogu.TabIndex = 2;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // btnDodajIR
            // 
            this.btnDodajIR.Location = new System.Drawing.Point(66, 197);
            this.btnDodajIR.Name = "btnDodajIR";
            this.btnDodajIR.Size = new System.Drawing.Size(208, 24);
            this.btnDodajIR.TabIndex = 3;
            this.btnDodajIR.Text = "Dodaj istrazivacki rezultat";
            this.btnDodajIR.UseVisualStyleBackColor = true;
            this.btnDodajIR.Click += new System.EventHandler(this.btnDodajIR_Click);
            // 
            // btnPoveziIstrazivacNII
            // 
            this.btnPoveziIstrazivacNII.Location = new System.Drawing.Point(66, 242);
            this.btnPoveziIstrazivacNII.Name = "btnPoveziIstrazivacNII";
            this.btnPoveziIstrazivacNII.Size = new System.Drawing.Size(207, 28);
            this.btnPoveziIstrazivacNII.TabIndex = 4;
            this.btnPoveziIstrazivacNII.Text = "Povezi NII i istrazivaca";
            this.btnPoveziIstrazivacNII.UseVisualStyleBackColor = true;
            this.btnPoveziIstrazivacNII.Click += new System.EventHandler(this.btnPoveziIstrazivacNII_Click);
            // 
            // btnDodajPublikaciju
            // 
            this.btnDodajPublikaciju.Location = new System.Drawing.Point(69, 290);
            this.btnDodajPublikaciju.Name = "btnDodajPublikaciju";
            this.btnDodajPublikaciju.Size = new System.Drawing.Size(203, 29);
            this.btnDodajPublikaciju.TabIndex = 5;
            this.btnDodajPublikaciju.Text = "Dodaj Publikaciju";
            this.btnDodajPublikaciju.UseVisualStyleBackColor = true;
            this.btnDodajPublikaciju.Click += new System.EventHandler(this.btnDodajPublikaciju_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajPublikaciju);
            this.Controls.Add(this.btnPoveziIstrazivacNII);
            this.Controls.Add(this.btnDodajIR);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.btnDodajIstrazivaca);
            this.Controls.Add(this.btnDodajNII);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajNII;
        private System.Windows.Forms.Button btnDodajIstrazivaca;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.Button btnDodajIR;
        private System.Windows.Forms.Button btnPoveziIstrazivacNII;
        private System.Windows.Forms.Button btnDodajPublikaciju;
    }
}

