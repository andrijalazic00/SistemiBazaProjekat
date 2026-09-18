namespace DigitalniRepozitorijum.Forms
{
    partial class FormIzmeniPublikaciju
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
            this.comboBPublikacija = new System.Windows.Forms.ComboBox();
            this.btnIzmeniPublikaciju = new System.Windows.Forms.Button();
            this.btnObrisiPublikaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publikacija za izmenu/brisanje";
            // 
            // comboBPublikacija
            // 
            this.comboBPublikacija.FormattingEnabled = true;
            this.comboBPublikacija.Location = new System.Drawing.Point(215, 24);
            this.comboBPublikacija.Name = "comboBPublikacija";
            this.comboBPublikacija.Size = new System.Drawing.Size(241, 21);
            this.comboBPublikacija.TabIndex = 1;
            // 
            // btnIzmeniPublikaciju
            // 
            this.btnIzmeniPublikaciju.Location = new System.Drawing.Point(53, 75);
            this.btnIzmeniPublikaciju.Name = "btnIzmeniPublikaciju";
            this.btnIzmeniPublikaciju.Size = new System.Drawing.Size(175, 25);
            this.btnIzmeniPublikaciju.TabIndex = 2;
            this.btnIzmeniPublikaciju.Text = "Izmeni";
            this.btnIzmeniPublikaciju.UseVisualStyleBackColor = true;
            this.btnIzmeniPublikaciju.Click += new System.EventHandler(this.btnIzmeniPublikaciju_Click);
            // 
            // btnObrisiPublikaciju
            // 
            this.btnObrisiPublikaciju.Location = new System.Drawing.Point(246, 72);
            this.btnObrisiPublikaciju.Name = "btnObrisiPublikaciju";
            this.btnObrisiPublikaciju.Size = new System.Drawing.Size(209, 27);
            this.btnObrisiPublikaciju.TabIndex = 3;
            this.btnObrisiPublikaciju.Text = "Obrisi";
            this.btnObrisiPublikaciju.UseVisualStyleBackColor = true;
            this.btnObrisiPublikaciju.Click += new System.EventHandler(this.btnObrisiPublikaciju_Click);
            // 
            // FormIzmeniPublikaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiPublikaciju);
            this.Controls.Add(this.btnIzmeniPublikaciju);
            this.Controls.Add(this.comboBPublikacija);
            this.Controls.Add(this.label1);
            this.Name = "FormIzmeniPublikaciju";
            this.Text = "FormIzmeniPublikaciju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBPublikacija;
        private System.Windows.Forms.Button btnIzmeniPublikaciju;
        private System.Windows.Forms.Button btnObrisiPublikaciju;
    }
}