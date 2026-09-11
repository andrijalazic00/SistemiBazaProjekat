namespace DigitalniRepozitorijum.Forms
{
    partial class FormDodajUlogu
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
            this.cBoxUloga = new System.Windows.Forms.ComboBox();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uloga";
            // 
            // cBoxUloga
            // 
            this.cBoxUloga.FormattingEnabled = true;
            this.cBoxUloga.Location = new System.Drawing.Point(116, 60);
            this.cBoxUloga.Name = "cBoxUloga";
            this.cBoxUloga.Size = new System.Drawing.Size(164, 21);
            this.cBoxUloga.TabIndex = 1;
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.Location = new System.Drawing.Point(50, 103);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(229, 33);
            this.btnDodajUlogu.TabIndex = 2;
            this.btnDodajUlogu.Text = "Dodaj ulogu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // FormDodajUlogu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 208);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.cBoxUloga);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajUlogu";
            this.Text = "FormDodajUlogu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxUloga;
        private System.Windows.Forms.Button btnDodajUlogu;
    }
}