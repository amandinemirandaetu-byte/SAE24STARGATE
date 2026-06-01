namespace SAE24STARGATE
{
    partial class UCDetailsMission
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
            this.grpTableauBord = new System.Windows.Forms.GroupBox();
            this.pnlTDBMission = new System.Windows.Forms.Panel();
            this.btnToutesMissions = new System.Windows.Forms.Button();
            this.btnFutur = new System.Windows.Forms.Button();
            this.btnPasse = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.grpInfosPlan = new System.Windows.Forms.GroupBox();
            this.panelPlanetes = new System.Windows.Forms.Panel();
            this.grpDecouvRaces = new System.Windows.Forms.GroupBox();
            this.panelAliens = new System.Windows.Forms.Panel();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.btnRechercherAliens = new System.Windows.Forms.Button();
            this.cboCouleursAliens = new System.Windows.Forms.ComboBox();
            this.txtNomAliens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomAlien = new System.Windows.Forms.Label();
            this.grpNouvMission = new System.Windows.Forms.GroupBox();
            this.btnAuthentifier = new System.Windows.Forms.Button();
            this.lblVeuillezAuthentifiez = new System.Windows.Forms.Label();
            this.pntMission = new SAE24STARGATE.Planete();
            this.grpTableauBord.SuspendLayout();
            this.grpInfosPlan.SuspendLayout();
            this.grpDecouvRaces.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.grpNouvMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTableauBord
            // 
            this.grpTableauBord.BackColor = System.Drawing.Color.Black;
            this.grpTableauBord.Controls.Add(this.pnlTDBMission);
            this.grpTableauBord.Controls.Add(this.btnToutesMissions);
            this.grpTableauBord.Controls.Add(this.btnFutur);
            this.grpTableauBord.Controls.Add(this.btnPasse);
            this.grpTableauBord.Controls.Add(this.btnPresent);
            this.grpTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTableauBord.Location = new System.Drawing.Point(194, 20);
            this.grpTableauBord.Margin = new System.Windows.Forms.Padding(2);
            this.grpTableauBord.Name = "grpTableauBord";
            this.grpTableauBord.Padding = new System.Windows.Forms.Padding(2);
            this.grpTableauBord.Size = new System.Drawing.Size(633, 536);
            this.grpTableauBord.TabIndex = 12;
            this.grpTableauBord.TabStop = false;
            this.grpTableauBord.Visible = false;
            // 
            // pnlTDBMission
            // 
            this.pnlTDBMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTDBMission.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.pnlTDBMission.ForeColor = System.Drawing.Color.Chartreuse;
            this.pnlTDBMission.Location = new System.Drawing.Point(55, 135);
            this.pnlTDBMission.MaximumSize = new System.Drawing.Size(525, 390);
            this.pnlTDBMission.MinimumSize = new System.Drawing.Size(525, 390);
            this.pnlTDBMission.Name = "pnlTDBMission";
            this.pnlTDBMission.Size = new System.Drawing.Size(525, 390);
            this.pnlTDBMission.TabIndex = 6;
            // 
            // btnToutesMissions
            // 
            this.btnToutesMissions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnToutesMissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToutesMissions.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.btnToutesMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnToutesMissions.Location = new System.Drawing.Point(54, 75);
            this.btnToutesMissions.Name = "btnToutesMissions";
            this.btnToutesMissions.Size = new System.Drawing.Size(525, 50);
            this.btnToutesMissions.TabIndex = 5;
            this.btnToutesMissions.Text = "Toutes Missions";
            this.btnToutesMissions.UseVisualStyleBackColor = true;
            // 
            // btnFutur
            // 
            this.btnFutur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnFutur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFutur.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.btnFutur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnFutur.Location = new System.Drawing.Point(409, 18);
            this.btnFutur.Name = "btnFutur";
            this.btnFutur.Size = new System.Drawing.Size(170, 50);
            this.btnFutur.TabIndex = 4;
            this.btnFutur.Text = "Futur";
            this.btnFutur.UseVisualStyleBackColor = true;
            // 
            // btnPasse
            // 
            this.btnPasse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasse.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.btnPasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnPasse.Location = new System.Drawing.Point(54, 18);
            this.btnPasse.Name = "btnPasse";
            this.btnPasse.Size = new System.Drawing.Size(170, 50);
            this.btnPasse.TabIndex = 3;
            this.btnPasse.Text = "Passe";
            this.btnPasse.UseVisualStyleBackColor = true;
            // 
            // btnPresent
            // 
            this.btnPresent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresent.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.btnPresent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnPresent.Location = new System.Drawing.Point(233, 18);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(170, 50);
            this.btnPresent.TabIndex = 2;
            this.btnPresent.Text = "En Cours";
            this.btnPresent.UseVisualStyleBackColor = true;
            // 
            // grpInfosPlan
            // 
            this.grpInfosPlan.Controls.Add(this.panelPlanetes);
            this.grpInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfosPlan.Location = new System.Drawing.Point(194, 20);
            this.grpInfosPlan.Margin = new System.Windows.Forms.Padding(2);
            this.grpInfosPlan.Name = "grpInfosPlan";
            this.grpInfosPlan.Padding = new System.Windows.Forms.Padding(2);
            this.grpInfosPlan.Size = new System.Drawing.Size(633, 536);
            this.grpInfosPlan.TabIndex = 14;
            this.grpInfosPlan.TabStop = false;
            this.grpInfosPlan.Visible = false;
            // 
            // panelPlanetes
            // 
            this.panelPlanetes.AutoScroll = true;
            this.panelPlanetes.Location = new System.Drawing.Point(3, 10);
            this.panelPlanetes.Margin = new System.Windows.Forms.Padding(2);
            this.panelPlanetes.Name = "panelPlanetes";
            this.panelPlanetes.Size = new System.Drawing.Size(627, 523);
            this.panelPlanetes.TabIndex = 0;
            // 
            // grpDecouvRaces
            // 
            this.grpDecouvRaces.Controls.Add(this.panelAliens);
            this.grpDecouvRaces.Controls.Add(this.grpFiltres);
            this.grpDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDecouvRaces.Location = new System.Drawing.Point(194, 20);
            this.grpDecouvRaces.Margin = new System.Windows.Forms.Padding(2);
            this.grpDecouvRaces.Name = "grpDecouvRaces";
            this.grpDecouvRaces.Padding = new System.Windows.Forms.Padding(2);
            this.grpDecouvRaces.Size = new System.Drawing.Size(633, 536);
            this.grpDecouvRaces.TabIndex = 13;
            this.grpDecouvRaces.TabStop = false;
            this.grpDecouvRaces.Visible = false;
            // 
            // panelAliens
            // 
            this.panelAliens.AutoScroll = true;
            this.panelAliens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAliens.ForeColor = System.Drawing.Color.Black;
            this.panelAliens.Location = new System.Drawing.Point(14, 143);
            this.panelAliens.Margin = new System.Windows.Forms.Padding(2);
            this.panelAliens.Name = "panelAliens";
            this.panelAliens.Size = new System.Drawing.Size(608, 378);
            this.panelAliens.TabIndex = 7;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.btnRechercherAliens);
            this.grpFiltres.Controls.Add(this.cboCouleursAliens);
            this.grpFiltres.Controls.Add(this.txtNomAliens);
            this.grpFiltres.Controls.Add(this.label1);
            this.grpFiltres.Controls.Add(this.lblNomAlien);
            this.grpFiltres.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.grpFiltres.Location = new System.Drawing.Point(14, 13);
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltres.Size = new System.Drawing.Size(607, 117);
            this.grpFiltres.TabIndex = 1;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnRechercherAliens
            // 
            this.btnRechercherAliens.BackgroundImage = global::SAE24STARGATE.Properties.Resources.iconeLoupe;
            this.btnRechercherAliens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRechercherAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherAliens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRechercherAliens.Location = new System.Drawing.Point(523, 27);
            this.btnRechercherAliens.Margin = new System.Windows.Forms.Padding(2);
            this.btnRechercherAliens.Name = "btnRechercherAliens";
            this.btnRechercherAliens.Size = new System.Drawing.Size(63, 62);
            this.btnRechercherAliens.TabIndex = 4;
            this.btnRechercherAliens.UseVisualStyleBackColor = true;
            // 
            // cboCouleursAliens
            // 
            this.cboCouleursAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboCouleursAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCouleursAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleursAliens.ForeColor = System.Drawing.Color.White;
            this.cboCouleursAliens.FormattingEnabled = true;
            this.cboCouleursAliens.Location = new System.Drawing.Point(121, 68);
            this.cboCouleursAliens.Margin = new System.Windows.Forms.Padding(2);
            this.cboCouleursAliens.Name = "cboCouleursAliens";
            this.cboCouleursAliens.Size = new System.Drawing.Size(365, 24);
            this.cboCouleursAliens.TabIndex = 3;
            // 
            // txtNomAliens
            // 
            this.txtNomAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtNomAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAliens.ForeColor = System.Drawing.Color.White;
            this.txtNomAliens.Location = new System.Drawing.Point(121, 29);
            this.txtNomAliens.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomAliens.Name = "txtNomAliens";
            this.txtNomAliens.Size = new System.Drawing.Size(365, 24);
            this.txtNomAliens.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Couleur :";
            // 
            // lblNomAlien
            // 
            this.lblNomAlien.AutoSize = true;
            this.lblNomAlien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblNomAlien.Location = new System.Drawing.Point(23, 30);
            this.lblNomAlien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomAlien.Name = "lblNomAlien";
            this.lblNomAlien.Size = new System.Drawing.Size(51, 17);
            this.lblNomAlien.TabIndex = 0;
            this.lblNomAlien.Text = "Nom :";
            // 
            // grpNouvMission
            // 
            this.grpNouvMission.Controls.Add(this.btnAuthentifier);
            this.grpNouvMission.Controls.Add(this.lblVeuillezAuthentifiez);
            this.grpNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNouvMission.Location = new System.Drawing.Point(194, 20);
            this.grpNouvMission.Margin = new System.Windows.Forms.Padding(2);
            this.grpNouvMission.Name = "grpNouvMission";
            this.grpNouvMission.Padding = new System.Windows.Forms.Padding(2);
            this.grpNouvMission.Size = new System.Drawing.Size(633, 536);
            this.grpNouvMission.TabIndex = 15;
            this.grpNouvMission.TabStop = false;
            this.grpNouvMission.Visible = false;
            // 
            // btnAuthentifier
            // 
            this.btnAuthentifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthentifier.Font = new System.Drawing.Font("Orbitron SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthentifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnAuthentifier.Location = new System.Drawing.Point(255, 425);
            this.btnAuthentifier.Name = "btnAuthentifier";
            this.btnAuthentifier.Size = new System.Drawing.Size(435, 75);
            this.btnAuthentifier.TabIndex = 1;
            this.btnAuthentifier.Text = "S\'authentifier :";
            this.btnAuthentifier.UseVisualStyleBackColor = true;
            // 
            // lblVeuillezAuthentifiez
            // 
            this.lblVeuillezAuthentifiez.AutoSize = true;
            this.lblVeuillezAuthentifiez.Font = new System.Drawing.Font("Orbitron", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeuillezAuthentifiez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblVeuillezAuthentifiez.Location = new System.Drawing.Point(173, 241);
            this.lblVeuillezAuthentifiez.Name = "lblVeuillezAuthentifiez";
            this.lblVeuillezAuthentifiez.Size = new System.Drawing.Size(417, 68);
            this.lblVeuillezAuthentifiez.TabIndex = 0;
            this.lblVeuillezAuthentifiez.Text = "Veuillez vous authentifier \r\npour voir ce contenu !";
            this.lblVeuillezAuthentifiez.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pntMission
            // 
            this.pntMission.BackColor = System.Drawing.Color.Black;
            this.pntMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pntMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pntMission.Location = new System.Drawing.Point(25, 30);
            this.pntMission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pntMission.Name = "pntMission";
            this.pntMission.Size = new System.Drawing.Size(130, 127);
            this.pntMission.TabIndex = 17;
            this.pntMission.Load += new System.EventHandler(this.planete1_Load);
            // 
            // UCDetailsMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pntMission);
            this.Controls.Add(this.grpTableauBord);
            this.Controls.Add(this.grpInfosPlan);
            this.Controls.Add(this.grpDecouvRaces);
            this.Controls.Add(this.grpNouvMission);
            this.Font = new System.Drawing.Font("Orbitron", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(851, 577);
            this.MinimumSize = new System.Drawing.Size(851, 577);
            this.Name = "UCDetailsMission";
            this.Size = new System.Drawing.Size(851, 577);
            this.Load += new System.EventHandler(this.UCDetailsMission_Load);
            this.grpTableauBord.ResumeLayout(false);
            this.grpInfosPlan.ResumeLayout(false);
            this.grpDecouvRaces.ResumeLayout(false);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.grpNouvMission.ResumeLayout(false);
            this.grpNouvMission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpTableauBord;
        private System.Windows.Forms.Panel pnlTDBMission;
        private System.Windows.Forms.Button btnToutesMissions;
        private System.Windows.Forms.Button btnFutur;
        private System.Windows.Forms.Button btnPasse;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.GroupBox grpInfosPlan;
        private System.Windows.Forms.Panel panelPlanetes;
        private System.Windows.Forms.GroupBox grpDecouvRaces;
        private System.Windows.Forms.Panel panelAliens;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Button btnRechercherAliens;
        private System.Windows.Forms.ComboBox cboCouleursAliens;
        private System.Windows.Forms.TextBox txtNomAliens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomAlien;
        private System.Windows.Forms.GroupBox grpNouvMission;
        private System.Windows.Forms.Button btnAuthentifier;
        private System.Windows.Forms.Label lblVeuillezAuthentifiez;
        private Planete pntMission;
    }
}
