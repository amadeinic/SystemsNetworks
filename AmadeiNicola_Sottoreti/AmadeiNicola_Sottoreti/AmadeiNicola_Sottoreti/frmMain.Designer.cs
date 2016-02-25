namespace AmadeiNicola_Sottoreti
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbInserimento = new System.Windows.Forms.GroupBox();
            this.nudReti = new System.Windows.Forms.NumericUpDown();
            this.lblNReti = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.dgvDati = new System.Windows.Forms.DataGridView();
            this.btnVai = new System.Windows.Forms.Button();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipaest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipbroad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeiphost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInserimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInserimento
            // 
            this.gpbInserimento.Controls.Add(this.nudReti);
            this.gpbInserimento.Controls.Add(this.lblNReti);
            this.gpbInserimento.Controls.Add(this.lblIP);
            this.gpbInserimento.Controls.Add(this.txtIP);
            this.gpbInserimento.Location = new System.Drawing.Point(13, 13);
            this.gpbInserimento.Name = "gpbInserimento";
            this.gpbInserimento.Size = new System.Drawing.Size(200, 84);
            this.gpbInserimento.TabIndex = 0;
            this.gpbInserimento.TabStop = false;
            this.gpbInserimento.Text = "Inserimento";
            // 
            // nudReti
            // 
            this.nudReti.Location = new System.Drawing.Point(94, 50);
            this.nudReti.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudReti.Name = "nudReti";
            this.nudReti.Size = new System.Drawing.Size(100, 20);
            this.nudReti.TabIndex = 3;
            // 
            // lblNReti
            // 
            this.lblNReti.AutoSize = true;
            this.lblNReti.Location = new System.Drawing.Point(7, 52);
            this.lblNReti.Name = "lblNReti";
            this.lblNReti.Size = new System.Drawing.Size(66, 13);
            this.lblNReti.TabIndex = 2;
            this.lblNReti.Text = "Numero Reti";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(7, 25);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(67, 13);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP (Classe C)";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            // 
            // dgvDati
            // 
            this.dgvDati.AllowUserToAddRows = false;
            this.dgvDati.AllowUserToDeleteRows = false;
            this.dgvDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord,
            this.ipaest,
            this.ipbroad,
            this.rangeiphost});
            this.dgvDati.Location = new System.Drawing.Point(220, 13);
            this.dgvDati.Name = "dgvDati";
            this.dgvDati.ReadOnly = true;
            this.dgvDati.Size = new System.Drawing.Size(768, 319);
            this.dgvDati.TabIndex = 1;
            // 
            // btnVai
            // 
            this.btnVai.Location = new System.Drawing.Point(132, 103);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(75, 23);
            this.btnVai.TabIndex = 2;
            this.btnVai.Text = "Vai";
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // Ord
            // 
            this.Ord.HeaderText = "Ord";
            this.Ord.Name = "Ord";
            this.Ord.ReadOnly = true;
            // 
            // ipaest
            // 
            this.ipaest.HeaderText = "Ip address rete estesa";
            this.ipaest.Name = "ipaest";
            this.ipaest.ReadOnly = true;
            // 
            // ipbroad
            // 
            this.ipbroad.HeaderText = "Ip broadcast";
            this.ipbroad.Name = "ipbroad";
            this.ipbroad.ReadOnly = true;
            // 
            // rangeiphost
            // 
            this.rangeiphost.HeaderText = "Range Ip address sottorete";
            this.rangeiphost.Name = "rangeiphost";
            this.rangeiphost.ReadOnly = true;
            this.rangeiphost.Width = 220;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 344);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.dgvDati);
            this.Controls.Add(this.gpbInserimento);
            this.Name = "frmMain";
            this.Text = "Sottoreti Amadei Nicola";
            this.gpbInserimento.ResumeLayout(false);
            this.gpbInserimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInserimento;
        private System.Windows.Forms.Label lblNReti;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.DataGridView dgvDati;
        private System.Windows.Forms.NumericUpDown nudReti;
        private System.Windows.Forms.Button btnVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipaest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipbroad;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeiphost;
    }
}

