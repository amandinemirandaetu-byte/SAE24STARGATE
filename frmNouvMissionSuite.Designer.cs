namespace SAE24STARGATE
{
    partial class frmNouvMissionSuite
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
            this.lblAffectationMembre = new System.Windows.Forms.Label();
            this.cboChoixMembre = new System.Windows.Forms.ComboBox();
            this.txtMembresMission = new System.Windows.Forms.TextBox();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.btnValiderMembre = new System.Windows.Forms.Button();
            this.btnRetirerMembre = new System.Windows.Forms.Button();
            this.btnRetirerObjectif = new System.Windows.Forms.Button();
            this.btnValiderObjectifs = new System.Windows.Forms.Button();
            this.btnAjouterObjectifCapture = new System.Windows.Forms.Button();
            this.txtResumeObjectifs = new System.Windows.Forms.TextBox();
            this.cboAliens = new System.Windows.Forms.ComboBox();
            this.lblObjectifsCaptures = new System.Windows.Forms.Label();
            this.nbrAliensCapture = new System.Windows.Forms.NumericUpDown();
            this.pnlObjectifCapture = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nbrAliensCapture)).BeginInit();
            this.pnlObjectifCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAffectationMembre
            // 
            this.lblAffectationMembre.AutoSize = true;
            this.lblAffectationMembre.Font = new System.Drawing.Font("Orbitron Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffectationMembre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblAffectationMembre.Location = new System.Drawing.Point(32, 23);
            this.lblAffectationMembre.Name = "lblAffectationMembre";
            this.lblAffectationMembre.Size = new System.Drawing.Size(650, 30);
            this.lblAffectationMembre.TabIndex = 8;
            this.lblAffectationMembre.Text = "4 - Affectation des membres - reste à affecter : ";
            // 
            // cboChoixMembre
            // 
            this.cboChoixMembre.Font = new System.Drawing.Font("Orbitron Medium", 8F);
            this.cboChoixMembre.FormattingEnabled = true;
            this.cboChoixMembre.Location = new System.Drawing.Point(57, 83);
            this.cboChoixMembre.Name = "cboChoixMembre";
            this.cboChoixMembre.Size = new System.Drawing.Size(602, 28);
            this.cboChoixMembre.TabIndex = 9;
            // 
            // txtMembresMission
            // 
            this.txtMembresMission.BackColor = System.Drawing.Color.Black;
            this.txtMembresMission.Font = new System.Drawing.Font("Orbitron Medium", 10F);
            this.txtMembresMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.txtMembresMission.Location = new System.Drawing.Point(57, 142);
            this.txtMembresMission.Multiline = true;
            this.txtMembresMission.Name = "txtMembresMission";
            this.txtMembresMission.ReadOnly = true;
            this.txtMembresMission.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMembresMission.Size = new System.Drawing.Size(818, 182);
            this.txtMembresMission.TabIndex = 10;
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterMembre.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnAjouterMembre.Location = new System.Drawing.Point(690, 77);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(185, 36);
            this.btnAjouterMembre.TabIndex = 11;
            this.btnAjouterMembre.Text = "Ajouter membre";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            this.btnAjouterMembre.Click += new System.EventHandler(this.btnAjouterMembre_Click);
            // 
            // btnValiderMembre
            // 
            this.btnValiderMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderMembre.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnValiderMembre.Location = new System.Drawing.Point(553, 358);
            this.btnValiderMembre.Name = "btnValiderMembre";
            this.btnValiderMembre.Size = new System.Drawing.Size(322, 36);
            this.btnValiderMembre.TabIndex = 12;
            this.btnValiderMembre.Text = "Valider membre(s)";
            this.btnValiderMembre.UseVisualStyleBackColor = true;
            this.btnValiderMembre.Click += new System.EventHandler(this.btnValiderMembre_Click);
            // 
            // btnRetirerMembre
            // 
            this.btnRetirerMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirerMembre.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnRetirerMembre.Location = new System.Drawing.Point(57, 358);
            this.btnRetirerMembre.Name = "btnRetirerMembre";
            this.btnRetirerMembre.Size = new System.Drawing.Size(267, 36);
            this.btnRetirerMembre.TabIndex = 13;
            this.btnRetirerMembre.Text = "Retirer membre";
            this.btnRetirerMembre.UseVisualStyleBackColor = true;
            this.btnRetirerMembre.Click += new System.EventHandler(this.btnRetirerMembre_Click);
            // 
            // btnRetirerObjectif
            // 
            this.btnRetirerObjectif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirerObjectif.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnRetirerObjectif.Location = new System.Drawing.Point(41, 359);
            this.btnRetirerObjectif.Name = "btnRetirerObjectif";
            this.btnRetirerObjectif.Size = new System.Drawing.Size(267, 36);
            this.btnRetirerObjectif.TabIndex = 19;
            this.btnRetirerObjectif.Text = "Retirer objectif";
            this.btnRetirerObjectif.UseVisualStyleBackColor = true;
            this.btnRetirerObjectif.Click += new System.EventHandler(this.btnRetirerObjectif_Click);
            // 
            // btnValiderObjectifs
            // 
            this.btnValiderObjectifs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderObjectifs.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnValiderObjectifs.Location = new System.Drawing.Point(537, 359);
            this.btnValiderObjectifs.Name = "btnValiderObjectifs";
            this.btnValiderObjectifs.Size = new System.Drawing.Size(322, 36);
            this.btnValiderObjectifs.TabIndex = 18;
            this.btnValiderObjectifs.Text = "Valider objectif(s)";
            this.btnValiderObjectifs.UseVisualStyleBackColor = true;
            this.btnValiderObjectifs.Click += new System.EventHandler(this.btnValiderObjectifs_Click);
            // 
            // btnAjouterObjectifCapture
            // 
            this.btnAjouterObjectifCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterObjectifCapture.Font = new System.Drawing.Font("Orbitron Medium", 9F);
            this.btnAjouterObjectifCapture.Location = new System.Drawing.Point(674, 78);
            this.btnAjouterObjectifCapture.Name = "btnAjouterObjectifCapture";
            this.btnAjouterObjectifCapture.Size = new System.Drawing.Size(185, 36);
            this.btnAjouterObjectifCapture.TabIndex = 17;
            this.btnAjouterObjectifCapture.Text = "Ajouter objectif";
            this.btnAjouterObjectifCapture.UseVisualStyleBackColor = true;
            this.btnAjouterObjectifCapture.Click += new System.EventHandler(this.btnAjouterObjectifCapture_Click);
            // 
            // txtResumeObjectifs
            // 
            this.txtResumeObjectifs.BackColor = System.Drawing.Color.Black;
            this.txtResumeObjectifs.Font = new System.Drawing.Font("Orbitron Medium", 10F);
            this.txtResumeObjectifs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.txtResumeObjectifs.Location = new System.Drawing.Point(41, 143);
            this.txtResumeObjectifs.Multiline = true;
            this.txtResumeObjectifs.Name = "txtResumeObjectifs";
            this.txtResumeObjectifs.ReadOnly = true;
            this.txtResumeObjectifs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumeObjectifs.Size = new System.Drawing.Size(818, 182);
            this.txtResumeObjectifs.TabIndex = 16;
            // 
            // cboAliens
            // 
            this.cboAliens.Font = new System.Drawing.Font("Orbitron Medium", 8F);
            this.cboAliens.FormattingEnabled = true;
            this.cboAliens.Location = new System.Drawing.Point(41, 84);
            this.cboAliens.Name = "cboAliens";
            this.cboAliens.Size = new System.Drawing.Size(372, 28);
            this.cboAliens.TabIndex = 15;
            // 
            // lblObjectifsCaptures
            // 
            this.lblObjectifsCaptures.AutoSize = true;
            this.lblObjectifsCaptures.Font = new System.Drawing.Font("Orbitron Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectifsCaptures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblObjectifsCaptures.Location = new System.Drawing.Point(16, 24);
            this.lblObjectifsCaptures.Name = "lblObjectifsCaptures";
            this.lblObjectifsCaptures.Size = new System.Drawing.Size(324, 30);
            this.lblObjectifsCaptures.TabIndex = 14;
            this.lblObjectifsCaptures.Text = "5 - Objectif de capture :";
            // 
            // nbrAliensCapture
            // 
            this.nbrAliensCapture.Location = new System.Drawing.Point(463, 84);
            this.nbrAliensCapture.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nbrAliensCapture.Name = "nbrAliensCapture";
            this.nbrAliensCapture.Size = new System.Drawing.Size(132, 26);
            this.nbrAliensCapture.TabIndex = 20;
            // 
            // pnlObjectifCapture
            // 
            this.pnlObjectifCapture.Controls.Add(this.nbrAliensCapture);
            this.pnlObjectifCapture.Controls.Add(this.btnRetirerObjectif);
            this.pnlObjectifCapture.Controls.Add(this.btnValiderObjectifs);
            this.pnlObjectifCapture.Controls.Add(this.btnAjouterObjectifCapture);
            this.pnlObjectifCapture.Controls.Add(this.txtResumeObjectifs);
            this.pnlObjectifCapture.Controls.Add(this.cboAliens);
            this.pnlObjectifCapture.Controls.Add(this.lblObjectifsCaptures);
            this.pnlObjectifCapture.Location = new System.Drawing.Point(16, 430);
            this.pnlObjectifCapture.Name = "pnlObjectifCapture";
            this.pnlObjectifCapture.Size = new System.Drawing.Size(893, 425);
            this.pnlObjectifCapture.TabIndex = 21;
            this.pnlObjectifCapture.Visible = false;
            // 
            // frmNouvMissionSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 869);
            this.Controls.Add(this.pnlObjectifCapture);
            this.Controls.Add(this.btnRetirerMembre);
            this.Controls.Add(this.btnValiderMembre);
            this.Controls.Add(this.btnAjouterMembre);
            this.Controls.Add(this.txtMembresMission);
            this.Controls.Add(this.cboChoixMembre);
            this.Controls.Add(this.lblAffectationMembre);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.MaximumSize = new System.Drawing.Size(950, 925);
            this.MinimumSize = new System.Drawing.Size(950, 925);
            this.Name = "frmNouvMissionSuite";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmNouvMissionSuite";
            this.Load += new System.EventHandler(this.frmNouvMissionSuite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrAliensCapture)).EndInit();
            this.pnlObjectifCapture.ResumeLayout(false);
            this.pnlObjectifCapture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffectationMembre;
        private System.Windows.Forms.ComboBox cboChoixMembre;
        private System.Windows.Forms.TextBox txtMembresMission;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.Button btnValiderMembre;
        private System.Windows.Forms.Button btnRetirerMembre;
        private System.Windows.Forms.Button btnRetirerObjectif;
        private System.Windows.Forms.Button btnValiderObjectifs;
        private System.Windows.Forms.Button btnAjouterObjectifCapture;
        private System.Windows.Forms.TextBox txtResumeObjectifs;
        private System.Windows.Forms.ComboBox cboAliens;
        private System.Windows.Forms.Label lblObjectifsCaptures;
        private System.Windows.Forms.NumericUpDown nbrAliensCapture;
        private System.Windows.Forms.Panel pnlObjectifCapture;
    }
}