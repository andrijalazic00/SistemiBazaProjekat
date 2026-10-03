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
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(57, 44);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(192, 39);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnBrisanjeAzuriranje
            // 
            this.btnBrisanjeAzuriranje.Location = new System.Drawing.Point(57, 116);
            this.btnBrisanjeAzuriranje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisanjeAzuriranje.Name = "btnBrisanjeAzuriranje";
            this.btnBrisanjeAzuriranje.Size = new System.Drawing.Size(192, 39);
            this.btnBrisanjeAzuriranje.TabIndex = 1;
            this.btnBrisanjeAzuriranje.Text = "Brisanje i azuriranje";
            this.btnBrisanjeAzuriranje.UseVisualStyleBackColor = true;
            this.btnBrisanjeAzuriranje.Click += new System.EventHandler(this.btnBrisanjeAzuriranje_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(57, 196);
            this.btnPrikaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(192, 39);
            this.btnPrikaz.TabIndex = 2;
            this.btnPrikaz.Text = "Prikaz";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // FormGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 283);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.btnBrisanjeAzuriranje);
            this.Controls.Add(this.btnUnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGlavnaForma";
            this.Text = "Selektor akcije";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnBrisanjeAzuriranje;
        private System.Windows.Forms.Button btnPrikaz;
    }
}