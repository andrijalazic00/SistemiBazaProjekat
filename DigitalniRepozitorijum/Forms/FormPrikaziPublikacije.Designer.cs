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
            this.btnPrikaziSelektovanu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublikacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorstva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRundeRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPublikacije
            // 
            this.dgvPublikacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublikacije.Location = new System.Drawing.Point(48, 113);
            this.dgvPublikacije.Name = "dgvPublikacije";
            this.dgvPublikacije.Size = new System.Drawing.Size(465, 133);
            this.dgvPublikacije.TabIndex = 0;
            // 
            // dgvAutorstva
            // 
            this.dgvAutorstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorstva.Location = new System.Drawing.Point(529, 287);
            this.dgvAutorstva.Name = "dgvAutorstva";
            this.dgvAutorstva.Size = new System.Drawing.Size(465, 131);
            this.dgvAutorstva.TabIndex = 1;
            // 
            // dgvCitati
            // 
            this.dgvCitati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitati.Location = new System.Drawing.Point(48, 287);
            this.dgvCitati.Name = "dgvCitati";
            this.dgvCitati.Size = new System.Drawing.Size(465, 129);
            this.dgvCitati.TabIndex = 2;
            // 
            // dgvRundeRecenzije
            // 
            this.dgvRundeRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRundeRecenzije.Location = new System.Drawing.Point(529, 113);
            this.dgvRundeRecenzije.Name = "dgvRundeRecenzije";
            this.dgvRundeRecenzije.Size = new System.Drawing.Size(465, 133);
            this.dgvRundeRecenzije.TabIndex = 3;
            // 
            // btnPrikaziSelektovanu
            // 
            this.btnPrikaziSelektovanu.Location = new System.Drawing.Point(48, 70);
            this.btnPrikaziSelektovanu.Name = "btnPrikaziSelektovanu";
            this.btnPrikaziSelektovanu.Size = new System.Drawing.Size(248, 32);
            this.btnPrikaziSelektovanu.TabIndex = 4;
            this.btnPrikaziSelektovanu.Text = "Detaljnije o selektovanoj publikaciji";
            this.btnPrikaziSelektovanu.UseVisualStyleBackColor = true;
            this.btnPrikaziSelektovanu.Click += new System.EventHandler(this.btnPrikaziSelektovanu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Runde recenzije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Citati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Autorstva";
            // 
            // FormPrikaziPublikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikaziSelektovanu);
            this.Controls.Add(this.dgvRundeRecenzije);
            this.Controls.Add(this.dgvCitati);
            this.Controls.Add(this.dgvAutorstva);
            this.Controls.Add(this.dgvPublikacije);
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
        private System.Windows.Forms.Button btnPrikaziSelektovanu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}