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
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upravljacka sekcija:";
            // 
            // tbUredjivackaSekcija
            // 
            this.tbUredjivackaSekcija.Location = new System.Drawing.Point(203, 32);
            this.tbUredjivackaSekcija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUredjivackaSekcija.Name = "tbUredjivackaSekcija";
            this.tbUredjivackaSekcija.Size = new System.Drawing.Size(263, 22);
            this.tbUredjivackaSekcija.TabIndex = 1;
            // 
            // btnDodajUpravljackuSekciju
            // 
            this.btnDodajUpravljackuSekciju.Location = new System.Drawing.Point(51, 74);
            this.btnDodajUpravljackuSekciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajUpravljackuSekciju.Name = "btnDodajUpravljackuSekciju";
            this.btnDodajUpravljackuSekciju.Size = new System.Drawing.Size(415, 35);
            this.btnDodajUpravljackuSekciju.TabIndex = 2;
            this.btnDodajUpravljackuSekciju.Text = "Dodaj upravljacku sekiciju i zatvori prozor";
            this.btnDodajUpravljackuSekciju.UseVisualStyleBackColor = true;
            this.btnDodajUpravljackuSekciju.Click += new System.EventHandler(this.btnDodajUpravljackuSekciju_Click);
            // 
            // FormDodajUrednika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 137);
            this.Controls.Add(this.btnDodajUpravljackuSekciju);
            this.Controls.Add(this.tbUredjivackaSekcija);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDodajUrednika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje urednika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUredjivackaSekcija;
        private System.Windows.Forms.Button btnDodajUpravljackuSekciju;
    }
}