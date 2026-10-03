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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodajAutora));
            this.btnDodajORCID = new System.Windows.Forms.Button();
            this.tbORCID = new System.Windows.Forms.TextBox();
            this.lblORCID = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajORCID
            // 
            this.btnDodajORCID.Location = new System.Drawing.Point(147, 102);
            this.btnDodajORCID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajORCID.Name = "btnDodajORCID";
            this.btnDodajORCID.Size = new System.Drawing.Size(272, 37);
            this.btnDodajORCID.TabIndex = 0;
            this.btnDodajORCID.Text = "Dodaj autora i zatvori prozor";
            this.btnDodajORCID.UseVisualStyleBackColor = true;
            this.btnDodajORCID.Click += new System.EventHandler(this.btnDodajORCID_Click);
            // 
            // tbORCID
            // 
            this.tbORCID.Location = new System.Drawing.Point(147, 47);
            this.tbORCID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbORCID.Name = "tbORCID";
            this.tbORCID.Size = new System.Drawing.Size(272, 22);
            this.tbORCID.TabIndex = 1;
            // 
            // lblORCID
            // 
            this.lblORCID.AutoSize = true;
            this.lblORCID.Location = new System.Drawing.Point(61, 50);
            this.lblORCID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblORCID.Name = "lblORCID";
            this.lblORCID.Size = new System.Drawing.Size(49, 16);
            this.lblORCID.TabIndex = 2;
            this.lblORCID.Text = "ORCID";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(459, 50);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(225, 16);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Format: NNNN-NNNN-NNNN-NNNX";
            // 
            // FormDodajAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 173);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblORCID);
            this.Controls.Add(this.tbORCID);
            this.Controls.Add(this.btnDodajORCID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDodajAutora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje autora";
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