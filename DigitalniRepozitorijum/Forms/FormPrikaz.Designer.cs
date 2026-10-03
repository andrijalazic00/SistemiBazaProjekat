namespace DigitalniRepozitorijum.Forms
{
    partial class FormPrikaz
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
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.btnPrikaziNII = new System.Windows.Forms.Button();
            this.btnPrikaziIstrazivace = new System.Windows.Forms.Button();
            this.btnPrikaziIR = new System.Windows.Forms.Button();
            this.btnPrikaziPublikacije = new System.Windows.Forms.Button();
            this.btnPrikaziAngazovanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(13, 58);
            this.dgvPodaci.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.Size = new System.Drawing.Size(1134, 440);
            this.dgvPodaci.TabIndex = 0;
            // 
            // btnPrikaziNII
            // 
            this.btnPrikaziNII.Location = new System.Drawing.Point(35, 13);
            this.btnPrikaziNII.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziNII.Name = "btnPrikaziNII";
            this.btnPrikaziNII.Size = new System.Drawing.Size(212, 37);
            this.btnPrikaziNII.TabIndex = 1;
            this.btnPrikaziNII.Text = "Prikazi NII";
            this.btnPrikaziNII.UseVisualStyleBackColor = true;
            this.btnPrikaziNII.Click += new System.EventHandler(this.btnPrikaziNII_Click);
            // 
            // btnPrikaziIstrazivace
            // 
            this.btnPrikaziIstrazivace.Location = new System.Drawing.Point(255, 13);
            this.btnPrikaziIstrazivace.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziIstrazivace.Name = "btnPrikaziIstrazivace";
            this.btnPrikaziIstrazivace.Size = new System.Drawing.Size(212, 37);
            this.btnPrikaziIstrazivace.TabIndex = 2;
            this.btnPrikaziIstrazivace.Text = "Prikazi istrazivace";
            this.btnPrikaziIstrazivace.UseVisualStyleBackColor = true;
            this.btnPrikaziIstrazivace.Click += new System.EventHandler(this.btnPrikaziIstrazivace_Click);
            // 
            // btnPrikaziIR
            // 
            this.btnPrikaziIR.Location = new System.Drawing.Point(475, 13);
            this.btnPrikaziIR.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziIR.Name = "btnPrikaziIR";
            this.btnPrikaziIR.Size = new System.Drawing.Size(212, 37);
            this.btnPrikaziIR.TabIndex = 3;
            this.btnPrikaziIR.Text = "Prikazi istrazivacke rezultate";
            this.btnPrikaziIR.UseVisualStyleBackColor = true;
            this.btnPrikaziIR.Click += new System.EventHandler(this.btnPrikaziIR_Click);
            // 
            // btnPrikaziPublikacije
            // 
            this.btnPrikaziPublikacije.Location = new System.Drawing.Point(695, 13);
            this.btnPrikaziPublikacije.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziPublikacije.Name = "btnPrikaziPublikacije";
            this.btnPrikaziPublikacije.Size = new System.Drawing.Size(212, 37);
            this.btnPrikaziPublikacije.TabIndex = 7;
            this.btnPrikaziPublikacije.Text = "PrikaziPublikacije";
            this.btnPrikaziPublikacije.UseVisualStyleBackColor = true;
            this.btnPrikaziPublikacije.Click += new System.EventHandler(this.btnPrikaziPublikacije_Click);
            // 
            // btnPrikaziAngazovanja
            // 
            this.btnPrikaziAngazovanja.Location = new System.Drawing.Point(915, 13);
            this.btnPrikaziAngazovanja.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrikaziAngazovanja.Name = "btnPrikaziAngazovanja";
            this.btnPrikaziAngazovanja.Size = new System.Drawing.Size(212, 37);
            this.btnPrikaziAngazovanja.TabIndex = 8;
            this.btnPrikaziAngazovanja.Text = "Prikazi angazovanja";
            this.btnPrikaziAngazovanja.UseVisualStyleBackColor = true;
            this.btnPrikaziAngazovanja.Click += new System.EventHandler(this.btnPrikaziAngazovanja_Click);
            // 
            // FormPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1155, 511);
            this.Controls.Add(this.btnPrikaziAngazovanja);
            this.Controls.Add(this.btnPrikaziPublikacije);
            this.Controls.Add(this.btnPrikaziIR);
            this.Controls.Add(this.btnPrikaziIstrazivace);
            this.Controls.Add(this.btnPrikaziNII);
            this.Controls.Add(this.dgvPodaci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrikaz";
            this.Text = "FormPrikaz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrikaz_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Button btnPrikaziNII;
        private System.Windows.Forms.Button btnPrikaziIstrazivace;
        private System.Windows.Forms.Button btnPrikaziIR;
        private System.Windows.Forms.Button btnPrikaziPublikacije;
        private System.Windows.Forms.Button btnPrikaziAngazovanja;
    }
}