namespace DigitalniRepozitorijum.Forms
{
    partial class FormObrisiFajl
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
            this.comboBoxFajl = new System.Windows.Forms.ComboBox();
            this.btnObrisiFajl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajl za brisanje";
            // 
            // comboBoxFajl
            // 
            this.comboBoxFajl.FormattingEnabled = true;
            this.comboBoxFajl.Location = new System.Drawing.Point(109, 25);
            this.comboBoxFajl.Name = "comboBoxFajl";
            this.comboBoxFajl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFajl.TabIndex = 1;
            // 
            // btnObrisiFajl
            // 
            this.btnObrisiFajl.Location = new System.Drawing.Point(27, 70);
            this.btnObrisiFajl.Name = "btnObrisiFajl";
            this.btnObrisiFajl.Size = new System.Drawing.Size(190, 28);
            this.btnObrisiFajl.TabIndex = 2;
            this.btnObrisiFajl.Text = "Obrisi fajl";
            this.btnObrisiFajl.UseVisualStyleBackColor = true;
            this.btnObrisiFajl.Click += new System.EventHandler(this.btnObrisiFajl_Click);
            // 
            // FormObrisiFajl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiFajl);
            this.Controls.Add(this.comboBoxFajl);
            this.Controls.Add(this.label1);
            this.Name = "FormObrisiFajl";
            this.Text = "FormObrisiFajl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFajl;
        private System.Windows.Forms.Button btnObrisiFajl;
    }
}