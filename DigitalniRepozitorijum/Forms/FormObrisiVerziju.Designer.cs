namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiVerziju
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
            this.comboBoxVerzija = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeniVerziju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verzija za brisanje";
            // 
            // comboBoxVerzija
            // 
            this.comboBoxVerzija.FormattingEnabled = true;
            this.comboBoxVerzija.Location = new System.Drawing.Point(187, 33);
            this.comboBoxVerzija.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVerzija.Name = "comboBoxVerzija";
            this.comboBoxVerzija.Size = new System.Drawing.Size(301, 24);
            this.comboBoxVerzija.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisi.Location = new System.Drawing.Point(283, 75);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(205, 31);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi verziju";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeniVerziju
            // 
            this.btnIzmeniVerziju.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeniVerziju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniVerziju.Location = new System.Drawing.Point(60, 75);
            this.btnIzmeniVerziju.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniVerziju.Name = "btnIzmeniVerziju";
            this.btnIzmeniVerziju.Size = new System.Drawing.Size(205, 31);
            this.btnIzmeniVerziju.TabIndex = 3;
            this.btnIzmeniVerziju.Text = "Izmeni verziju";
            this.btnIzmeniVerziju.UseVisualStyleBackColor = false;
            this.btnIzmeniVerziju.Click += new System.EventHandler(this.btnIzmeniVerziju_Click);
            // 
            // FormObrisiVerziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 162);
            this.Controls.Add(this.btnIzmeniVerziju);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.comboBoxVerzija);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormObrisiVerziju";
            this.Text = "FormObrisiVerziju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVerzija;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeniVerziju;
    }
}