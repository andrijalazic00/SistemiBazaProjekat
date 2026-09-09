namespace DigitalniRepozitorijum
{
    partial class FormDodajRecezenta
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
            this.btnOblastEkspertize = new System.Windows.Forms.Button();
            this.tbOblastEkspertize = new System.Windows.Forms.TextBox();
            this.lblOblatEkspertize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOblastEkspertize
            // 
            this.btnOblastEkspertize.Location = new System.Drawing.Point(379, 88);
            this.btnOblastEkspertize.Name = "btnOblastEkspertize";
            this.btnOblastEkspertize.Size = new System.Drawing.Size(148, 32);
            this.btnOblastEkspertize.TabIndex = 0;
            this.btnOblastEkspertize.Text = "DodajOblastEkspertize";
            this.btnOblastEkspertize.UseVisualStyleBackColor = true;
            this.btnOblastEkspertize.Click += new System.EventHandler(this.btnOblastEkspertize_Click);
            // 
            // tbOblastEkspertize
            // 
            this.tbOblastEkspertize.Location = new System.Drawing.Point(147, 94);
            this.tbOblastEkspertize.Name = "tbOblastEkspertize";
            this.tbOblastEkspertize.Size = new System.Drawing.Size(205, 20);
            this.tbOblastEkspertize.TabIndex = 1;
            // 
            // lblOblatEkspertize
            // 
            this.lblOblatEkspertize.AutoSize = true;
            this.lblOblatEkspertize.Location = new System.Drawing.Point(20, 98);
            this.lblOblatEkspertize.Name = "lblOblatEkspertize";
            this.lblOblatEkspertize.Size = new System.Drawing.Size(88, 13);
            this.lblOblatEkspertize.TabIndex = 2;
            this.lblOblatEkspertize.Text = "Oblast ekspertize";
            // 
            // FormDodajRecezenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOblatEkspertize);
            this.Controls.Add(this.tbOblastEkspertize);
            this.Controls.Add(this.btnOblastEkspertize);
            this.Name = "FormDodajRecezenta";
            this.Text = "FormDodajRecezenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblastEkspertize;
        private System.Windows.Forms.TextBox tbOblastEkspertize;
        private System.Windows.Forms.Label lblOblatEkspertize;
    }
}