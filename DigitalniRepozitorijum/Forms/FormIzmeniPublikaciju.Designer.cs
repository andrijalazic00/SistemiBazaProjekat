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
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publikacija za izmenu/brisanje";
            // 
            // comboBPublikacija
            // 
            this.comboBPublikacija.FormattingEnabled = true;
            this.comboBPublikacija.Location = new System.Drawing.Point(287, 30);
            this.comboBPublikacija.Margin = new System.Windows.Forms.Padding(4);
            this.comboBPublikacija.Name = "comboBPublikacija";
            this.comboBPublikacija.Size = new System.Drawing.Size(359, 24);
            this.comboBPublikacija.TabIndex = 1;
            // 
            // btnIzmeniPublikaciju
            // 
            this.btnIzmeniPublikaciju.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzmeniPublikaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzmeniPublikaciju.Location = new System.Drawing.Point(69, 80);
            this.btnIzmeniPublikaciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmeniPublikaciju.Name = "btnIzmeniPublikaciju";
            this.btnIzmeniPublikaciju.Size = new System.Drawing.Size(279, 33);
            this.btnIzmeniPublikaciju.TabIndex = 2;
            this.btnIzmeniPublikaciju.Text = "Izmeni";
            this.btnIzmeniPublikaciju.UseVisualStyleBackColor = false;
            this.btnIzmeniPublikaciju.Click += new System.EventHandler(this.btnIzmeniPublikaciju_Click);
            // 
            // btnObrisiPublikaciju
            // 
            this.btnObrisiPublikaciju.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisiPublikaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiPublikaciju.Location = new System.Drawing.Point(368, 80);
            this.btnObrisiPublikaciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiPublikaciju.Name = "btnObrisiPublikaciju";
            this.btnObrisiPublikaciju.Size = new System.Drawing.Size(279, 33);
            this.btnObrisiPublikaciju.TabIndex = 3;
            this.btnObrisiPublikaciju.Text = "Obrisi";
            this.btnObrisiPublikaciju.UseVisualStyleBackColor = false;
            this.btnObrisiPublikaciju.Click += new System.EventHandler(this.btnObrisiPublikaciju_Click);
            // 
            // FormIzmeniPublikaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 134);
            this.Controls.Add(this.btnObrisiPublikaciju);
            this.Controls.Add(this.btnIzmeniPublikaciju);
            this.Controls.Add(this.comboBPublikacija);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIzmeniPublikaciju";
            this.Text = "Izmene publikacije";
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