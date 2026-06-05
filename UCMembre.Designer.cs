namespace SAE24STARGATE
{
    partial class UCMembre
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPlaneteOrigine = new System.Windows.Forms.Label();
            this.lblMetier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblNom.Location = new System.Drawing.Point(10, 10);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "NOM";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblPrenom.Location = new System.Drawing.Point(10, 38);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(79, 17);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "PRENOM";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblDateNaissance.Location = new System.Drawing.Point(10, 100);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(131, 17);
            this.lblDateNaissance.TabIndex = 3;
            this.lblDateNaissance.Text = "DateNaissance";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblId.Location = new System.Drawing.Point(10, 69);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // lblPlaneteOrigine
            // 
            this.lblPlaneteOrigine.AutoSize = true;
            this.lblPlaneteOrigine.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblPlaneteOrigine.Location = new System.Drawing.Point(10, 161);
            this.lblPlaneteOrigine.Name = "lblPlaneteOrigine";
            this.lblPlaneteOrigine.Size = new System.Drawing.Size(124, 17);
            this.lblPlaneteOrigine.TabIndex = 5;
            this.lblPlaneteOrigine.Text = "PlaneteOrigine";
            // 
            // lblMetier
            // 
            this.lblMetier.AutoSize = true;
            this.lblMetier.Font = new System.Drawing.Font("Orbitron", 10F);
            this.lblMetier.Location = new System.Drawing.Point(10, 131);
            this.lblMetier.Name = "lblMetier";
            this.lblMetier.Size = new System.Drawing.Size(57, 17);
            this.lblMetier.TabIndex = 4;
            this.lblMetier.Text = "Metier";
            // 
            // UCMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblPlaneteOrigine);
            this.Controls.Add(this.lblMetier);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UCMembre";
            this.Size = new System.Drawing.Size(180, 200);
            this.Load += new System.EventHandler(this.UCMembre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPlaneteOrigine;
        private System.Windows.Forms.Label lblMetier;
    }
}
