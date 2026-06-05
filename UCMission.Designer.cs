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
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblNbrMembres = new System.Windows.Forms.Label();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.lblnbrMembres = new System.Windows.Forms.Label();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDetails.Location = new System.Drawing.Point(365, 15);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(120, 120);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblDateRetour
            // lblPlanete
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblDateRetour.Location = new System.Drawing.Point(199, 61);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(97, 20);
            this.lblDateRetour.TabIndex = 1;
            this.lblDateRetour.Text = "Date Retour";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblDepart.Location = new System.Drawing.Point(21, 61);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(94, 20);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Date depart";
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblPlanete.Location = new System.Drawing.Point(50, 25);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(69, 17);
            this.lblPlanete.TabIndex = 2;
            this.lblPlanete.Text = "Planete";
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Controls.Add(this.lblPlanete);
            this.Controls.Add(this.btnDetails);
            this.Font = new System.Drawing.Font("Orbitron", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "UCMission";
            this.Size = new System.Drawing.Size(498, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDateArrivee;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblNbrMembres;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblnbrMembres;
        private System.Windows.Forms.Label lblPlanete;
    }
}
