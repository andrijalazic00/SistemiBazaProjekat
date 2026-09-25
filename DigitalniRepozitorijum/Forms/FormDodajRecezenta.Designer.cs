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
            this.btnOblastEkspertize.Location = new System.Drawing.Point(195, 79);
            this.btnOblastEkspertize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOblastEkspertize.Name = "btnOblastEkspertize";
            this.btnOblastEkspertize.Size = new System.Drawing.Size(197, 39);
            this.btnOblastEkspertize.TabIndex = 0;
            this.btnOblastEkspertize.Text = "Dodaj oblast ekspertize";
            this.btnOblastEkspertize.UseVisualStyleBackColor = true;
            this.btnOblastEkspertize.Click += new System.EventHandler(this.btnOblastEkspertize_Click);
            // 
            // tbOblastEkspertize
            // 
            this.tbOblastEkspertize.Location = new System.Drawing.Point(195, 36);
            this.tbOblastEkspertize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOblastEkspertize.Name = "tbOblastEkspertize";
            this.tbOblastEkspertize.Size = new System.Drawing.Size(299, 22);
            this.tbOblastEkspertize.TabIndex = 1;
            // 
            // lblOblatEkspertize
            // 
            this.lblOblatEkspertize.AutoSize = true;
            this.lblOblatEkspertize.Location = new System.Drawing.Point(55, 39);
            this.lblOblatEkspertize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOblatEkspertize.Name = "lblOblatEkspertize";
            this.lblOblatEkspertize.Size = new System.Drawing.Size(111, 16);
            this.lblOblatEkspertize.TabIndex = 2;
            this.lblOblatEkspertize.Text = "Oblast ekspertize";
            // 
            // FormDodajRecezenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 154);
            this.Controls.Add(this.lblOblatEkspertize);
            this.Controls.Add(this.tbOblastEkspertize);
            this.Controls.Add(this.btnOblastEkspertize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodajRecezenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje recenzenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblastEkspertize;
        private System.Windows.Forms.TextBox tbOblastEkspertize;
        private System.Windows.Forms.Label lblOblatEkspertize;
    }
}