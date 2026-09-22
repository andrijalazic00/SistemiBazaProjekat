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
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citat za izmenu/brisanje";
            // 
            // comboBCitati
            // 
            this.comboBCitati.FormattingEnabled = true;
            this.comboBCitati.Location = new System.Drawing.Point(227, 36);
            this.comboBCitati.Name = "comboBCitati";
            this.comboBCitati.Size = new System.Drawing.Size(462, 21);
            this.comboBCitati.TabIndex = 1;
            // 
            // btnObrisiCitat
            // 
            this.btnObrisiCitat.Location = new System.Drawing.Point(73, 72);
            this.btnObrisiCitat.Name = "btnObrisiCitat";
            this.btnObrisiCitat.Size = new System.Drawing.Size(131, 32);
            this.btnObrisiCitat.TabIndex = 2;
            this.btnObrisiCitat.Text = "Obrisi";
            this.btnObrisiCitat.UseVisualStyleBackColor = true;
            this.btnObrisiCitat.Click += new System.EventHandler(this.btnObrisiCitat_Click);
            // 
            // btnIzmeniCitat
            // 
            this.btnIzmeniCitat.Location = new System.Drawing.Point(242, 72);
            this.btnIzmeniCitat.Name = "btnIzmeniCitat";
            this.btnIzmeniCitat.Size = new System.Drawing.Size(151, 24);
            this.btnIzmeniCitat.TabIndex = 3;
            this.btnIzmeniCitat.Text = "Izmeni";
            this.btnIzmeniCitat.UseVisualStyleBackColor = true;
            this.btnIzmeniCitat.Click += new System.EventHandler(this.btnIzmeniCitat_Click);
            // 
            // FormIzmeniCitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzmeniCitat);
            this.Controls.Add(this.btnObrisiCitat);
            this.Controls.Add(this.comboBCitati);
            this.Controls.Add(this.label1);
            this.Name = "FormIzmeniCitat";
            this.Text = "FormIzmeniCitat";
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