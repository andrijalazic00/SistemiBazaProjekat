namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniCitat
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
            this.comboBCitati = new System.Windows.Forms.ComboBox();
            this.btnObrisiCitat = new System.Windows.Forms.Button();
            this.btnIzmeniCitat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citat za izmenu/brisanje";
            // 
            // comboBCitati
            // 
            this.comboBCitati.FormattingEnabled = true;
            this.comboBCitati.Location = new System.Drawing.Point(263, 46);
            this.comboBCitati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBCitati.Name = "comboBCitati";
            this.comboBCitati.Size = new System.Drawing.Size(387, 24);
            this.comboBCitati.TabIndex = 1;
            // 
            // btnObrisiCitat
            // 
            this.btnObrisiCitat.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisiCitat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiCitat.Location = new System.Drawing.Point(96, 78);
            this.btnObrisiCitat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiCitat.Name = "btnObrisiCitat";
            this.btnObrisiCitat.Size = new System.Drawing.Size(266, 30);
            this.btnObrisiCitat.TabIndex = 2;
            this.btnObrisiCitat.Text = "Obrisi";
            this.btnObrisiCitat.UseVisualStyleBackColor = false;
            this.btnObrisiCitat.Click += new System.EventHandler(this.btnObrisiCitat_Click);
            // 
            // btnIzmeniCitat
            // 
            this.btnIzmeniCitat.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeniCitat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniCitat.Location = new System.Drawing.Point(384, 78);
            this.btnIzmeniCitat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzmeniCitat.Name = "btnIzmeniCitat";
            this.btnIzmeniCitat.Size = new System.Drawing.Size(266, 30);
            this.btnIzmeniCitat.TabIndex = 3;
            this.btnIzmeniCitat.Text = "Izmeni";
            this.btnIzmeniCitat.UseVisualStyleBackColor = false;
            this.btnIzmeniCitat.Click += new System.EventHandler(this.btnIzmeniCitat_Click);
            // 
            // FormIzmeniCitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 162);
            this.Controls.Add(this.btnIzmeniCitat);
            this.Controls.Add(this.btnObrisiCitat);
            this.Controls.Add(this.comboBCitati);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIzmeniCitat";
            this.Text = "Izmene citata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBCitati;
        private System.Windows.Forms.Button btnObrisiCitat;
        private System.Windows.Forms.Button btnIzmeniCitat;
    }
}