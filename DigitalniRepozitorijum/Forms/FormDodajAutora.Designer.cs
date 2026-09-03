namespace DigitalniRepozitorijum
{
    partial class FormDodajAutora
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
            this.btnDodajORCID = new System.Windows.Forms.Button();
            this.tbORCID = new System.Windows.Forms.TextBox();
            this.lblORCID = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajORCID
            // 
            this.btnDodajORCID.Location = new System.Drawing.Point(131, 125);
            this.btnDodajORCID.Name = "btnDodajORCID";
            this.btnDodajORCID.Size = new System.Drawing.Size(163, 50);
            this.btnDodajORCID.TabIndex = 0;
            this.btnDodajORCID.Text = "Dodaj autora i zatvori prozor";
            this.btnDodajORCID.UseVisualStyleBackColor = true;
            this.btnDodajORCID.Click += new System.EventHandler(this.btnDodajORCID_Click);
            // 
            // tbORCID
            // 
            this.tbORCID.Location = new System.Drawing.Point(131, 75);
            this.tbORCID.Name = "tbORCID";
            this.tbORCID.Size = new System.Drawing.Size(205, 20);
            this.tbORCID.TabIndex = 1;
            // 
            // lblORCID
            // 
            this.lblORCID.AutoSize = true;
            this.lblORCID.Location = new System.Drawing.Point(54, 82);
            this.lblORCID.Name = "lblORCID";
            this.lblORCID.Size = new System.Drawing.Size(41, 13);
            this.lblORCID.TabIndex = 2;
            this.lblORCID.Text = "ORCID";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(355, 82);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(181, 13);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Format: NNNN-NNNN-NNNN-NNNX";
            // 
            // FormDodajAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblORCID);
            this.Controls.Add(this.tbORCID);
            this.Controls.Add(this.btnDodajORCID);
            this.Name = "FormDodajAutora";
            this.Text = "FormDodajAutora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajORCID;
        private System.Windows.Forms.TextBox tbORCID;
        private System.Windows.Forms.Label lblORCID;
        private System.Windows.Forms.Label lblFormat;
    }
}