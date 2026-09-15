namespace DigitalniRepozitorijum.Forms
{
    partial class FormGlavnaForma
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnBrisanjeAzuriranje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(45, 31);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(128, 32);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnBrisanjeAzuriranje
            // 
            this.btnBrisanjeAzuriranje.Location = new System.Drawing.Point(211, 35);
            this.btnBrisanjeAzuriranje.Name = "btnBrisanjeAzuriranje";
            this.btnBrisanjeAzuriranje.Size = new System.Drawing.Size(144, 27);
            this.btnBrisanjeAzuriranje.TabIndex = 1;
            this.btnBrisanjeAzuriranje.Text = "Brisanje i azuriranje";
            this.btnBrisanjeAzuriranje.UseVisualStyleBackColor = true;
            this.btnBrisanjeAzuriranje.Click += new System.EventHandler(this.btnBrisanjeAzuriranje_Click);
            // 
            // FormGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrisanjeAzuriranje);
            this.Controls.Add(this.btnUnos);
            this.Name = "FormGlavnaForma";
            this.Text = "FormGlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnBrisanjeAzuriranje;
    }
}