namespace DigitalniRepozitorijum.Forms
{
    partial class FormPrikaziPublikacije
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
            this.dgvPublikacije = new System.Windows.Forms.DataGridView();
            this.dgvAutorstva = new System.Windows.Forms.DataGridView();
            this.dgvCitati = new System.Windows.Forms.DataGridView();
            this.dgvRundeRecenzije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublikacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRundeRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublikacije
            // 
            this.dgvPublikacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublikacije.Location = new System.Drawing.Point(13, 29);
            this.dgvPublikacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPublikacije.Name = "dgvPublikacije";
            this.dgvPublikacije.Size = new System.Drawing.Size(532, 245);
            this.dgvPublikacije.TabIndex = 0;
            this.dgvPublikacije.SelectionChanged += new System.EventHandler(this.dgvPublikacije_SelectionChanged);
            // 
            // dgvAutorstva
            // 
            this.dgvAutorstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorstva.Location = new System.Drawing.Point(553, 29);
            this.dgvAutorstva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAutorstva.Name = "dgvAutorstva";
            this.dgvAutorstva.Size = new System.Drawing.Size(604, 245);
            this.dgvAutorstva.TabIndex = 1;
            // 
            // dgvCitati
            // 
            this.dgvCitati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitati.Location = new System.Drawing.Point(13, 441);
            this.dgvCitati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCitati.Name = "dgvCitati";
            this.dgvCitati.Size = new System.Drawing.Size(1144, 123);
            this.dgvCitati.TabIndex = 2;
            // 
            // dgvRundeRecenzije
            // 
            this.dgvRundeRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRundeRecenzije.Location = new System.Drawing.Point(13, 298);
            this.dgvRundeRecenzije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRundeRecenzije.Name = "dgvRundeRecenzije";
            this.dgvRundeRecenzije.Size = new System.Drawing.Size(1144, 119);
            this.dgvRundeRecenzije.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Runde recenzije selektovane publikacije:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Citati selektovane publikacije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autorstva selektovane publikacije:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Publikacije:";
            // 
            // FormPrikaziPublikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRundeRecenzije);
            this.Controls.Add(this.dgvCitati);
            this.Controls.Add(this.dgvAutorstva);
            this.Controls.Add(this.dgvPublikacije);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrikaziPublikacije";
            this.Text = "FormPrikaziPublikacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublikacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorstva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRundeRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublikacije;
        private System.Windows.Forms.DataGridView dgvAutorstva;
        private System.Windows.Forms.DataGridView dgvCitati;
        private System.Windows.Forms.DataGridView dgvRundeRecenzije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}