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
            this.btnPrikaziPodklasu = new System.Windows.Forms.Button();
            this.dgvDodatnaSvojstva = new System.Windows.Forms.DataGridView();
            this.lblTipRezultata = new System.Windows.Forms.Label();
            this.btnPrikaziPublikacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatnaSvojstva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(12, 127);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.Size = new System.Drawing.Size(727, 253);
            this.dgvPodaci.TabIndex = 0;
            // 
            // btnPrikaziNII
            // 
            this.btnPrikaziNII.Location = new System.Drawing.Point(110, 45);
            this.btnPrikaziNII.Name = "btnPrikaziNII";
            this.btnPrikaziNII.Size = new System.Drawing.Size(132, 30);
            this.btnPrikaziNII.TabIndex = 1;
            this.btnPrikaziNII.Text = "Prikazi NII";
            this.btnPrikaziNII.UseVisualStyleBackColor = true;
            this.btnPrikaziNII.Click += new System.EventHandler(this.btnPrikaziNII_Click);
            // 
            // btnPrikaziIstrazivace
            // 
            this.btnPrikaziIstrazivace.Location = new System.Drawing.Point(279, 45);
            this.btnPrikaziIstrazivace.Name = "btnPrikaziIstrazivace";
            this.btnPrikaziIstrazivace.Size = new System.Drawing.Size(132, 32);
            this.btnPrikaziIstrazivace.TabIndex = 2;
            this.btnPrikaziIstrazivace.Text = "Prikazi istrazivace";
            this.btnPrikaziIstrazivace.UseVisualStyleBackColor = true;
            this.btnPrikaziIstrazivace.Click += new System.EventHandler(this.btnPrikaziIstrazivace_Click);
            // 
            // btnPrikaziIR
            // 
            this.btnPrikaziIR.Location = new System.Drawing.Point(454, 45);
            this.btnPrikaziIR.Name = "btnPrikaziIR";
            this.btnPrikaziIR.Size = new System.Drawing.Size(159, 32);
            this.btnPrikaziIR.TabIndex = 3;
            this.btnPrikaziIR.Text = "Prikazi istrazivacke rezultate";
            this.btnPrikaziIR.UseVisualStyleBackColor = true;
            this.btnPrikaziIR.Click += new System.EventHandler(this.btnPrikaziIR_Click);
            // 
            // btnPrikaziPodklasu
            // 
            this.btnPrikaziPodklasu.Location = new System.Drawing.Point(658, 45);
            this.btnPrikaziPodklasu.Name = "btnPrikaziPodklasu";
            this.btnPrikaziPodklasu.Size = new System.Drawing.Size(178, 32);
            this.btnPrikaziPodklasu.TabIndex = 4;
            this.btnPrikaziPodklasu.Text = "Prikazi podklasu selektovanog IR";
            this.btnPrikaziPodklasu.UseVisualStyleBackColor = true;
            this.btnPrikaziPodklasu.Click += new System.EventHandler(this.btnPrikaziPodklasu_Click);
            // 
            // dgvDodatnaSvojstva
            // 
            this.dgvDodatnaSvojstva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodatnaSvojstva.Location = new System.Drawing.Point(745, 127);
            this.dgvDodatnaSvojstva.Name = "dgvDodatnaSvojstva";
            this.dgvDodatnaSvojstva.Size = new System.Drawing.Size(270, 253);
            this.dgvDodatnaSvojstva.TabIndex = 5;
            // 
            // lblTipRezultata
            // 
            this.lblTipRezultata.AutoSize = true;
            this.lblTipRezultata.Location = new System.Drawing.Point(742, 101);
            this.lblTipRezultata.Name = "lblTipRezultata";
            this.lblTipRezultata.Size = new System.Drawing.Size(65, 13);
            this.lblTipRezultata.TabIndex = 6;
            this.lblTipRezultata.Text = "Tip rezultata";
            // 
            // btnPrikaziPublikacije
            // 
            this.btnPrikaziPublikacije.Location = new System.Drawing.Point(857, 45);
            this.btnPrikaziPublikacije.Name = "btnPrikaziPublikacije";
            this.btnPrikaziPublikacije.Size = new System.Drawing.Size(133, 29);
            this.btnPrikaziPublikacije.TabIndex = 7;
            this.btnPrikaziPublikacije.Text = "PrikaziPublikacije";
            this.btnPrikaziPublikacije.UseVisualStyleBackColor = true;
            this.btnPrikaziPublikacije.Click += new System.EventHandler(this.btnPrikaziPublikacije_Click);
            // 
            // FormPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 497);
            this.Controls.Add(this.btnPrikaziPublikacije);
            this.Controls.Add(this.lblTipRezultata);
            this.Controls.Add(this.dgvDodatnaSvojstva);
            this.Controls.Add(this.btnPrikaziPodklasu);
            this.Controls.Add(this.btnPrikaziIR);
            this.Controls.Add(this.btnPrikaziIstrazivace);
            this.Controls.Add(this.btnPrikaziNII);
            this.Controls.Add(this.dgvPodaci);
            this.Name = "FormPrikaz";
            this.Text = "FormPrikaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodatnaSvojstva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Button btnPrikaziNII;
        private System.Windows.Forms.Button btnPrikaziIstrazivace;
        private System.Windows.Forms.Button btnPrikaziIR;
        private System.Windows.Forms.Button btnPrikaziPodklasu;
        private System.Windows.Forms.DataGridView dgvDodatnaSvojstva;
        private System.Windows.Forms.Label lblTipRezultata;
        private System.Windows.Forms.Button btnPrikaziPublikacije;
    }
}