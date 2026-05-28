namespace SAE24STARGATE
{
    partial class UCMission
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblNbrMembres = new System.Windows.Forms.Label();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.button1.Location = new System.Drawing.Point(372, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblPlanete.Location = new System.Drawing.Point(389, 108);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(69, 17);
            this.lblPlanete.TabIndex = 1;
            this.lblPlanete.Text = "Planete";
            this.lblPlanete.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNomMission.Location = new System.Drawing.Point(50, 25);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(103, 17);
            this.lblNomMission.TabIndex = 2;
            this.lblNomMission.Text = "NomMission";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNumMission.Location = new System.Drawing.Point(209, 25);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(103, 17);
            this.lblNumMission.TabIndex = 3;
            this.lblNumMission.Text = "NumMission";
            // 
            // lblDateArrivee
            // 
            this.lblDateArrivee.AutoSize = true;
            this.lblDateArrivee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblDateArrivee.Location = new System.Drawing.Point(209, 67);
            this.lblDateArrivee.Name = "lblDateArrivee";
            this.lblDateArrivee.Size = new System.Drawing.Size(106, 17);
            this.lblDateArrivee.TabIndex = 5;
            this.lblDateArrivee.Text = "DateArrivee";
            this.lblDateArrivee.Click += new System.EventHandler(this.lblDateArrivee_Click);
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblDateDepart.Location = new System.Drawing.Point(50, 67);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(100, 17);
            this.lblDateDepart.TabIndex = 4;
            this.lblDateDepart.Text = "DateDepart";
            // 
            // lblNbrMembres
            // 
            this.lblNbrMembres.AutoSize = true;
            this.lblNbrMembres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNbrMembres.Location = new System.Drawing.Point(209, 108);
            this.lblNbrMembres.Name = "lblNbrMembres";
            this.lblNbrMembres.Size = new System.Drawing.Size(109, 17);
            this.lblNbrMembres.TabIndex = 7;
            this.lblNbrMembres.Text = "NbrMembres";
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblChefMission.Location = new System.Drawing.Point(50, 108);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(45, 17);
            this.lblChefMission.TabIndex = 6;
            this.lblChefMission.Text = "Chef";
            // 
            // UCMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblNbrMembres);
            this.Controls.Add(this.lblChefMission);
            this.Controls.Add(this.lblDateArrivee);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.lblNumMission);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Orbitron", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "UCMission";
            this.Size = new System.Drawing.Size(498, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDateArrivee;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblNbrMembres;
        private System.Windows.Forms.Label lblChefMission;
    }
}
