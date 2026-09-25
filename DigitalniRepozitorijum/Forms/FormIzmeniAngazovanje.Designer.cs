namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniAngazovanje
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.comboBAngazovanje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeni.Location = new System.Drawing.Point(37, 62);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(302, 28);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi.Location = new System.Drawing.Point(353, 62);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(302, 28);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // comboBAngazovanje
            // 
            this.comboBAngazovanje.FormattingEnabled = true;
            this.comboBAngazovanje.Location = new System.Drawing.Point(254, 30);
            this.comboBAngazovanje.Margin = new System.Windows.Forms.Padding(4);
            this.comboBAngazovanje.Name = "comboBAngazovanje";
            this.comboBAngazovanje.Size = new System.Drawing.Size(401, 24);
            this.comboBAngazovanje.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Angazovanje za izmenu/brisanje";
            // 
            // FormIzmeniAngazovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBAngazovanje);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIzmeniAngazovanje";
            this.Text = "Izmena angazovanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox comboBAngazovanje;
        private System.Windows.Forms.Label label1;
    }
}