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
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajl za brisanje";
            // 
            // comboBoxFajl
            // 
            this.comboBoxFajl.FormattingEnabled = true;
            this.comboBoxFajl.Location = new System.Drawing.Point(145, 31);
            this.comboBoxFajl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFajl.Name = "comboBoxFajl";
            this.comboBoxFajl.Size = new System.Drawing.Size(306, 24);
            this.comboBoxFajl.TabIndex = 1;
            // 
            // btnObrisiFajl
            // 
            this.btnObrisiFajl.Location = new System.Drawing.Point(117, 63);
            this.btnObrisiFajl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiFajl.Name = "btnObrisiFajl";
            this.btnObrisiFajl.Size = new System.Drawing.Size(269, 24);
            this.btnObrisiFajl.TabIndex = 2;
            this.btnObrisiFajl.Text = "Obrisi fajl";
            this.btnObrisiFajl.UseVisualStyleBackColor = true;
            this.btnObrisiFajl.Click += new System.EventHandler(this.btnObrisiFajl_Click);
            // 
            // FormObrisiFajl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(507, 107);
            this.Controls.Add(this.btnObrisiFajl);
            this.Controls.Add(this.comboBoxFajl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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