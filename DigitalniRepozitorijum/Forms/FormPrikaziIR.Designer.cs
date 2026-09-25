namespace DigitalniRepozitorijum.Forms
{
    partial class FormPrikaziIR
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
            this.dgvIstrazivackiRezultati = new System.Windows.Forms.DataGridView();
            this.dgvPodKlasa = new System.Windows.Forms.DataGridView();
            this.lblTipRezultata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstrazivackiRezultati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodKlasa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIstrazivackiRezultati
            // 
            this.dgvIstrazivackiRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstrazivackiRezultati.Location = new System.Drawing.Point(13, 46);
            this.dgvIstrazivackiRezultati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIstrazivackiRezultati.Name = "dgvIstrazivackiRezultati";
            this.dgvIstrazivackiRezultati.Size = new System.Drawing.Size(918, 588);
            this.dgvIstrazivackiRezultati.TabIndex = 0;
            this.dgvIstrazivackiRezultati.SelectionChanged += new System.EventHandler(this.onSelectionChanged);
            // 
            // dgvPodKlasa
            // 
            this.dgvPodKlasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodKlasa.Location = new System.Drawing.Point(939, 46);
            this.dgvPodKlasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPodKlasa.Name = "dgvPodKlasa";
            this.dgvPodKlasa.Size = new System.Drawing.Size(245, 588);
            this.dgvPodKlasa.TabIndex = 1;
            // 
            // lblTipRezultata
            // 
            this.lblTipRezultata.AutoSize = true;
            this.lblTipRezultata.Location = new System.Drawing.Point(935, 26);
            this.lblTipRezultata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipRezultata.Name = "lblTipRezultata";
            this.lblTipRezultata.Size = new System.Drawing.Size(250, 16);
            this.lblTipRezultata.TabIndex = 2;
            this.lblTipRezultata.Text = "Tip selektovanog istrazivackog rezultata:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Istrazivacki rezultati:";
            // 
            // FormPrikaziIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipRezultata);
            this.Controls.Add(this.dgvPodKlasa);
            this.Controls.Add(this.dgvIstrazivackiRezultati);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrikaziIR";
            this.Text = "FormPrikaziIR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrikaziIR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstrazivackiRezultati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodKlasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIstrazivackiRezultati;
        private System.Windows.Forms.DataGridView dgvPodKlasa;
        private System.Windows.Forms.Label lblTipRezultata;
        private System.Windows.Forms.Label label1;
    }
}