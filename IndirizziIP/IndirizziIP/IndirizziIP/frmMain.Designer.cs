namespace IndirizziIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtIPBin = new System.Windows.Forms.TextBox();
            this.txtSubMask = new System.Windows.Forms.TextBox();
            this.txtSubBin = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtIndirizzoBin = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblSubMask = new System.Windows.Forms.Label();
            this.lblSubBin = new System.Windows.Forms.Label();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblIndirizzoBin = new System.Windows.Forms.Label();
            this.btnVai = new System.Windows.Forms.Button();
            this.cmbIP = new System.Windows.Forms.ComboBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIPBin
            // 
            this.txtIPBin.Location = new System.Drawing.Point(175, 33);
            this.txtIPBin.Name = "txtIPBin";
            this.txtIPBin.Size = new System.Drawing.Size(331, 22);
            this.txtIPBin.TabIndex = 1;
            // 
            // txtSubMask
            // 
            this.txtSubMask.Location = new System.Drawing.Point(16, 78);
            this.txtSubMask.Name = "txtSubMask";
            this.txtSubMask.Size = new System.Drawing.Size(130, 22);
            this.txtSubMask.TabIndex = 2;
            // 
            // txtSubBin
            // 
            this.txtSubBin.Location = new System.Drawing.Point(175, 78);
            this.txtSubBin.Name = "txtSubBin";
            this.txtSubBin.Size = new System.Drawing.Size(331, 22);
            this.txtSubBin.TabIndex = 3;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(16, 127);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(130, 22);
            this.txtIndirizzo.TabIndex = 4;
            // 
            // txtIndirizzoBin
            // 
            this.txtIndirizzoBin.Location = new System.Drawing.Point(175, 127);
            this.txtIndirizzoBin.Name = "txtIndirizzoBin";
            this.txtIndirizzoBin.Size = new System.Drawing.Size(331, 22);
            this.txtIndirizzoBin.TabIndex = 5;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(13, 13);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(20, 17);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP";
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(172, 13);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(68, 17);
            this.lblBinario.TabIndex = 7;
            this.lblBinario.Text = "IP Binario";
            // 
            // lblSubMask
            // 
            this.lblSubMask.AutoSize = true;
            this.lblSubMask.Location = new System.Drawing.Point(13, 58);
            this.lblSubMask.Name = "lblSubMask";
            this.lblSubMask.Size = new System.Drawing.Size(90, 17);
            this.lblSubMask.TabIndex = 8;
            this.lblSubMask.Text = "Subnet Mask";
            // 
            // lblSubBin
            // 
            this.lblSubBin.AutoSize = true;
            this.lblSubBin.Location = new System.Drawing.Point(172, 58);
            this.lblSubBin.Name = "lblSubBin";
            this.lblSubBin.Size = new System.Drawing.Size(77, 17);
            this.lblSubBin.TabIndex = 9;
            this.lblSubBin.Text = "Subnet Bin";
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(13, 107);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(60, 17);
            this.lblIndirizzo.TabIndex = 10;
            this.lblIndirizzo.Text = "Indirizzo";
            // 
            // lblIndirizzoBin
            // 
            this.lblIndirizzoBin.AutoSize = true;
            this.lblIndirizzoBin.Location = new System.Drawing.Point(172, 107);
            this.lblIndirizzoBin.Name = "lblIndirizzoBin";
            this.lblIndirizzoBin.Size = new System.Drawing.Size(84, 17);
            this.lblIndirizzoBin.TabIndex = 11;
            this.lblIndirizzoBin.Text = "Indirizzo Bin";
            // 
            // btnVai
            // 
            this.btnVai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVai.Location = new System.Drawing.Point(624, 18);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(155, 131);
            this.btnVai.TabIndex = 12;
            this.btnVai.Text = "Vai!";
            this.btnVai.UseVisualStyleBackColor = false;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // cmbIP
            // 
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Location = new System.Drawing.Point(16, 33);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(130, 24);
            this.cmbIP.TabIndex = 0;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblClasse.Location = new System.Drawing.Point(512, 18);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(0, 106);
            this.lblClasse.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 170);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.cmbIP);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.lblIndirizzoBin);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.lblSubBin);
            this.Controls.Add(this.lblSubMask);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.txtIndirizzoBin);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.txtSubBin);
            this.Controls.Add(this.txtSubMask);
            this.Controls.Add(this.txtIPBin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "BitCricket by Nicola Amadei 4H Lab. 008";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIPBin;
        private System.Windows.Forms.TextBox txtSubMask;
        private System.Windows.Forms.TextBox txtSubBin;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtIndirizzoBin;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblSubMask;
        private System.Windows.Forms.Label lblSubBin;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Label lblIndirizzoBin;
        private System.Windows.Forms.Button btnVai;
        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Label lblClasse;
    }
}

