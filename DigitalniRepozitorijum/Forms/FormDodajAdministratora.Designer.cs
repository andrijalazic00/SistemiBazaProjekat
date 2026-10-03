namespace DigitalniRepozitorijum
{
    partial class FormDodajAdministratora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajAdministratora));
            this.tbOvlascenje = new System.Windows.Forms.TextBox();
            this.lblOvlascenja = new System.Windows.Forms.Label();
            this.btnDodajOvlascenje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOvlascenje
            // 
            this.tbOvlascenje.Location = new System.Drawing.Point(205, 44);
            this.tbOvlascenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOvlascenje.Name = "tbOvlascenje";
            this.tbOvlascenje.Size = new System.Drawing.Size(261, 22);
            this.tbOvlascenje.TabIndex = 0;
            // 
            // lblOvlascenja
            // 
            this.lblOvlascenja.AutoSize = true;
            this.lblOvlascenja.Location = new System.Drawing.Point(90, 47);
            this.lblOvlascenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOvlascenja.Name = "lblOvlascenja";
            this.lblOvlascenja.Size = new System.Drawing.Size(78, 16);
            this.lblOvlascenja.TabIndex = 1;
            this.lblOvlascenja.Text = "Ovlascenja:";
            // 
            // btnDodajOvlascenje
            // 
            this.btnDodajOvlascenje.Location = new System.Drawing.Point(205, 93);
            this.btnDodajOvlascenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajOvlascenje.Name = "btnDodajOvlascenje";
            this.btnDodajOvlascenje.Size = new System.Drawing.Size(261, 31);
            this.btnDodajOvlascenje.TabIndex = 2;
            this.btnDodajOvlascenje.Text = "Dodaj ovlascenje";
            this.btnDodajOvlascenje.UseVisualStyleBackColor = true;
            this.btnDodajOvlascenje.Click += new System.EventHandler(this.btnDodajOvlascenje_Click);
            // 
            // FormDodajAdministratora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 189);
            this.Controls.Add(this.btnDodajOvlascenje);
            this.Controls.Add(this.lblOvlascenja);
            this.Controls.Add(this.tbOvlascenje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodajAdministratora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodajvanje ovlascenja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOvlascenje;
        private System.Windows.Forms.Label lblOvlascenja;
        private System.Windows.Forms.Button btnDodajOvlascenje;
    }
}