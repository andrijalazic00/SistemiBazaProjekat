namespace DigitalniRepozitorijum
{
    partial class FormDodajUrednika
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
            this.tbUredjivackaSekcija = new System.Windows.Forms.TextBox();
            this.btnDodajUpravljackuSekciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upravljacka sekcija:";
            // 
            // tbUredjivackaSekcija
            // 
            this.tbUredjivackaSekcija.Location = new System.Drawing.Point(201, 69);
            this.tbUredjivackaSekcija.Name = "tbUredjivackaSekcija";
            this.tbUredjivackaSekcija.Size = new System.Drawing.Size(146, 20);
            this.tbUredjivackaSekcija.TabIndex = 1;
            // 
            // btnDodajUpravljackuSekciju
            // 
            this.btnDodajUpravljackuSekciju.Location = new System.Drawing.Point(57, 127);
            this.btnDodajUpravljackuSekciju.Name = "btnDodajUpravljackuSekciju";
            this.btnDodajUpravljackuSekciju.Size = new System.Drawing.Size(256, 89);
            this.btnDodajUpravljackuSekciju.TabIndex = 2;
            this.btnDodajUpravljackuSekciju.Text = "Dodaj upravljacku sekiciju i zatvori prozor";
            this.btnDodajUpravljackuSekciju.UseVisualStyleBackColor = true;
            this.btnDodajUpravljackuSekciju.Click += new System.EventHandler(this.btnDodajUpravljackuSekciju_Click);
            // 
            // FormDodajUrednika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajUpravljackuSekciju);
            this.Controls.Add(this.tbUredjivackaSekcija);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajUrednika";
            this.Text = "FormDodajUrednika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUredjivackaSekcija;
        private System.Windows.Forms.Button btnDodajUpravljackuSekciju;
    }
}