namespace SAE24STARGATE
{
    partial class frmAccueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTbBord = new System.Windows.Forms.Button();
            this.btnDecouvRaces = new System.Windows.Forms.Button();
            this.btnNouvMission = new System.Windows.Forms.Button();
            this.BtnInfosPlan = new System.Windows.Forms.Button();
            this.grpTableauBord = new System.Windows.Forms.GroupBox();
            this.btnFutur = new System.Windows.Forms.Button();
            this.btnPasse = new System.Windows.Forms.Button();
            this.btnPresent = new System.Windows.Forms.Button();
            this.grpMissionsTDB = new System.Windows.Forms.GroupBox();
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
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.btnPageStatistiques = new System.Windows.Forms.Button();
            this.btnTableauBord = new System.Windows.Forms.Button();
            this.btnDecouverteRaces = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnInfosPlanete = new System.Windows.Forms.Button();
            this.tabPageStatistiques = new System.Windows.Forms.TabPage();
            this.grpStatistiques = new System.Windows.Forms.GroupBox();
            this.btnRechercherPlaneteMission = new System.Windows.Forms.Button();
            this.cboPlanetes = new System.Windows.Forms.ComboBox();
            this.lblPlanetesMissions = new System.Windows.Forms.Label();
            this.btnRechercherBudget = new System.Windows.Forms.Button();
            this.btnRechercheCoequipiers = new System.Windows.Forms.Button();
            this.lblLstDepenses = new System.Windows.Forms.Label();
            this.cboChoixMission = new System.Windows.Forms.ComboBox();
            this.lblBudgetMissionTitre = new System.Windows.Forms.Label();
            this.cboNoms = new System.Windows.Forms.ComboBox();
            this.lblCoequipiersTitre = new System.Windows.Forms.Label();
            this.lblTitreStats = new System.Windows.Forms.Label();
            this.btnMenuStats = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.grpTableauBord.SuspendLayout();
            this.grpInfosPlan.SuspendLayout();
            this.grpDecouvRaces.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.tabPageStatistiques.SuspendLayout();
            this.grpStatistiques.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabPagePrincipal);
            this.tabMenu.Controls.Add(this.tabPageMenu);
            this.tabMenu.Controls.Add(this.tabPageStatistiques);
            this.tabMenu.Location = new System.Drawing.Point(-7, -23);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(859, 603);
            this.tabMenu.TabIndex = 4;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.BackColor = System.Drawing.Color.Black;
            this.tabPagePrincipal.Controls.Add(this.btnMenu);
            this.tabPagePrincipal.Controls.Add(this.btnTbBord);
            this.tabPagePrincipal.Controls.Add(this.btnDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.btnNouvMission);
            this.tabPagePrincipal.Controls.Add(this.BtnInfosPlan);
            this.tabPagePrincipal.Controls.Add(this.grpTableauBord);
            this.tabPagePrincipal.Controls.Add(this.grpInfosPlan);
            this.tabPagePrincipal.Controls.Add(this.grpDecouvRaces);
            this.tabPagePrincipal.Controls.Add(this.grpNouvMission);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePrincipal.Size = new System.Drawing.Size(851, 577);
            this.tabPagePrincipal.TabIndex = 1;
            this.tabPagePrincipal.Text = "tabPage2";
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::SAE24STARGATE.Properties.Resources.boutonMenu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(23, 500);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(150, 46);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "button1";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTbBord
            // 
            this.btnTbBord.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnTableauBord;
            this.btnTbBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTbBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnTbBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTbBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTbBord.Location = new System.Drawing.Point(23, 20);
            this.btnTbBord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTbBord.Name = "btnTbBord";
            this.btnTbBord.Size = new System.Drawing.Size(150, 98);
            this.btnTbBord.TabIndex = 0;
            this.btnTbBord.UseVisualStyleBackColor = true;
            this.btnTbBord.Click += new System.EventHandler(this.btnTbBord_Click);
            // 
            // btnDecouvRaces
            // 
            this.btnDecouvRaces.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnDecouvRaces;
            this.btnDecouvRaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecouvRaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnDecouvRaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecouvRaces.Location = new System.Drawing.Point(23, 136);
            this.btnDecouvRaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecouvRaces.Name = "btnDecouvRaces";
            this.btnDecouvRaces.Size = new System.Drawing.Size(150, 98);
            this.btnDecouvRaces.TabIndex = 1;
            this.btnDecouvRaces.UseVisualStyleBackColor = true;
            this.btnDecouvRaces.Click += new System.EventHandler(this.btnDecouvRaces_Click);
            // 
            // btnNouvMission
            // 
            this.btnNouvMission.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnNouvMission;
            this.btnNouvMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNouvMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnNouvMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvMission.Location = new System.Drawing.Point(23, 260);
            this.btnNouvMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouvMission.Name = "btnNouvMission";
            this.btnNouvMission.Size = new System.Drawing.Size(150, 98);
            this.btnNouvMission.TabIndex = 2;
            this.btnNouvMission.UseVisualStyleBackColor = true;
            this.btnNouvMission.Click += new System.EventHandler(this.btnNouvMission_Click);
            // 
            // BtnInfosPlan
            // 
            this.BtnInfosPlan.BackgroundImage = global::SAE24STARGATE.Properties.Resources.btnInfosPlanete;
            this.BtnInfosPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInfosPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.BtnInfosPlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.BtnInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInfosPlan.Location = new System.Drawing.Point(23, 384);
            this.BtnInfosPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnInfosPlan.Name = "BtnInfosPlan";
            this.BtnInfosPlan.Size = new System.Drawing.Size(150, 98);
            this.BtnInfosPlan.TabIndex = 3;
            this.BtnInfosPlan.UseVisualStyleBackColor = true;
            this.BtnInfosPlan.Click += new System.EventHandler(this.BtnInfosPlan_Click);
            // 
            // grpTableauBord
            // 
            this.grpTableauBord.BackColor = System.Drawing.Color.Black;
            this.grpTableauBord.Controls.Add(this.btnFutur);
            this.grpTableauBord.Controls.Add(this.btnPasse);
            this.grpTableauBord.Controls.Add(this.btnPresent);
            this.grpTableauBord.Controls.Add(this.grpMissionsTDB);
            this.grpTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTableauBord.Location = new System.Drawing.Point(193, 13);
            this.grpTableauBord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTableauBord.Name = "grpTableauBord";
            this.grpTableauBord.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTableauBord.Size = new System.Drawing.Size(633, 536);
            this.grpTableauBord.TabIndex = 4;
            this.grpTableauBord.TabStop = false;
            this.grpTableauBord.Visible = false;
            // 
            // btnFutur
            // 
            this.btnFutur.Location = new System.Drawing.Point(409, 18);
            this.btnFutur.Name = "btnFutur";
            this.btnFutur.Size = new System.Drawing.Size(170, 50);
            this.btnFutur.TabIndex = 4;
            this.btnFutur.Text = "button3";
            this.btnFutur.UseVisualStyleBackColor = true;
            // 
            // btnPasse
            // 
            this.btnPasse.Location = new System.Drawing.Point(54, 18);
            this.btnPasse.Name = "btnPasse";
            this.btnPasse.Size = new System.Drawing.Size(170, 50);
            this.btnPasse.TabIndex = 3;
            this.btnPasse.Text = "button2";
            this.btnPasse.UseVisualStyleBackColor = true;
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(233, 18);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(170, 50);
            this.btnPresent.TabIndex = 2;
            this.btnPresent.Text = "button1";
            this.btnPresent.UseVisualStyleBackColor = true;
            // 
            // grpMissionsTDB
            // 
            this.grpMissionsTDB.Location = new System.Drawing.Point(54, 69);
            this.grpMissionsTDB.MaximumSize = new System.Drawing.Size(525, 450);
            this.grpMissionsTDB.MinimumSize = new System.Drawing.Size(525, 450);
            this.grpMissionsTDB.Name = "grpMissionsTDB";
            this.grpMissionsTDB.Padding = new System.Windows.Forms.Padding(0);
            this.grpMissionsTDB.Size = new System.Drawing.Size(525, 450);
            this.grpMissionsTDB.TabIndex = 0;
            this.grpMissionsTDB.TabStop = false;
            // 
            // grpInfosPlan
            // 
            this.grpInfosPlan.Controls.Add(this.panelPlanetes);
            this.grpInfosPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInfosPlan.Location = new System.Drawing.Point(193, 13);
            this.grpInfosPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfosPlan.Name = "grpInfosPlan";
            this.grpInfosPlan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpInfosPlan.Size = new System.Drawing.Size(633, 536);
            this.grpInfosPlan.TabIndex = 6;
            this.grpInfosPlan.TabStop = false;
            this.grpInfosPlan.Visible = false;
            // 
            // panelPlanetes
            // 
            this.panelPlanetes.AutoScroll = true;
            this.panelPlanetes.Location = new System.Drawing.Point(3, 10);
            this.panelPlanetes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPlanetes.Name = "panelPlanetes";
            this.panelPlanetes.Size = new System.Drawing.Size(627, 523);
            this.panelPlanetes.TabIndex = 0;
            // 
            // grpDecouvRaces
            // 
            this.grpDecouvRaces.Controls.Add(this.panelAliens);
            this.grpDecouvRaces.Controls.Add(this.grpFiltres);
            this.grpDecouvRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDecouvRaces.Location = new System.Drawing.Point(193, 13);
            this.grpDecouvRaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecouvRaces.Name = "grpDecouvRaces";
            this.grpDecouvRaces.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDecouvRaces.Size = new System.Drawing.Size(633, 536);
            this.grpDecouvRaces.TabIndex = 5;
            this.grpDecouvRaces.TabStop = false;
            this.grpDecouvRaces.Visible = false;
            // 
            // panelAliens
            // 
            this.panelAliens.AutoScroll = true;
            this.panelAliens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAliens.ForeColor = System.Drawing.Color.Black;
            this.panelAliens.Location = new System.Drawing.Point(14, 143);
            this.panelAliens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltres.Size = new System.Drawing.Size(607, 117);
            this.grpFiltres.TabIndex = 1;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnRechercherAliens
            // 
            this.btnRechercherAliens.BackgroundImage = global::SAE24STARGATE.Properties.Resources.iconeLoupe1;
            this.btnRechercherAliens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRechercherAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherAliens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRechercherAliens.Location = new System.Drawing.Point(523, 27);
            this.btnRechercherAliens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercherAliens.Name = "btnRechercherAliens";
            this.btnRechercherAliens.Size = new System.Drawing.Size(63, 62);
            this.btnRechercherAliens.TabIndex = 4;
            this.btnRechercherAliens.UseVisualStyleBackColor = true;
            this.btnRechercherAliens.Click += new System.EventHandler(this.btnRechercherAliens_Click);
            // 
            // cboCouleursAliens
            // 
            this.cboCouleursAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.cboCouleursAliens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCouleursAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleursAliens.ForeColor = System.Drawing.Color.White;
            this.cboCouleursAliens.FormattingEnabled = true;
            this.cboCouleursAliens.Location = new System.Drawing.Point(121, 68);
            this.cboCouleursAliens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCouleursAliens.Name = "cboCouleursAliens";
            this.cboCouleursAliens.Size = new System.Drawing.Size(365, 24);
            this.cboCouleursAliens.TabIndex = 3;
            this.cboCouleursAliens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCouleursAliens_KeyPress);
            // 
            // txtNomAliens
            // 
            this.txtNomAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.txtNomAliens.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAliens.ForeColor = System.Drawing.Color.White;
            this.txtNomAliens.Location = new System.Drawing.Point(121, 29);
            this.txtNomAliens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomAliens.Name = "txtNomAliens";
            this.txtNomAliens.Size = new System.Drawing.Size(365, 24);
            this.txtNomAliens.TabIndex = 2;
            this.txtNomAliens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAliens_KeyPress);
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
            this.grpNouvMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpNouvMission.Location = new System.Drawing.Point(193, 13);
            this.grpNouvMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNouvMission.Name = "grpNouvMission";
            this.grpNouvMission.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNouvMission.Size = new System.Drawing.Size(633, 536);
            this.grpNouvMission.TabIndex = 6;
            this.grpNouvMission.TabStop = false;
            this.grpNouvMission.Visible = false;
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.BackColor = System.Drawing.Color.Black;
            this.tabPageMenu.BackgroundImage = global::SAE24STARGATE.Properties.Resources.BGimg1;
            this.tabPageMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPageMenu.Controls.Add(this.btnPageStatistiques);
            this.tabPageMenu.Controls.Add(this.btnTableauBord);
            this.tabPageMenu.Controls.Add(this.btnDecouverteRaces);
            this.tabPageMenu.Controls.Add(this.btnNouvelleMission);
            this.tabPageMenu.Controls.Add(this.btnInfosPlanete);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageMenu.Size = new System.Drawing.Size(851, 577);
            this.tabPageMenu.TabIndex = 0;
            this.tabPageMenu.Text = "tabPage1";
            // 
            // btnPageStatistiques
            // 
            this.btnPageStatistiques.BackColor = System.Drawing.Color.Transparent;
            this.btnPageStatistiques.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPageStatistiques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPageStatistiques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPageStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageStatistiques.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPageStatistiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnPageStatistiques.Location = new System.Drawing.Point(309, 510);
            this.btnPageStatistiques.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPageStatistiques.Name = "btnPageStatistiques";
            this.btnPageStatistiques.Size = new System.Drawing.Size(233, 36);
            this.btnPageStatistiques.TabIndex = 4;
            this.btnPageStatistiques.Text = "Statistiques";
            this.btnPageStatistiques.UseVisualStyleBackColor = false;
            this.btnPageStatistiques.Click += new System.EventHandler(this.btnPageStatistiques_Click);
            // 
            // btnTableauBord
            // 
            this.btnTableauBord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTableauBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.BorderSize = 0;
            this.btnTableauBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableauBord.Font = new System.Drawing.Font("Orbitron", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnTableauBord.Location = new System.Drawing.Point(110, 281);
            this.btnTableauBord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTableauBord.Name = "btnTableauBord";
            this.btnTableauBord.Size = new System.Drawing.Size(231, 213);
            this.btnTableauBord.TabIndex = 0;
            this.btnTableauBord.Text = "Tableau\r\nde bord";
            this.btnTableauBord.UseVisualStyleBackColor = false;
            this.btnTableauBord.Click += new System.EventHandler(this.btnTableauBord_Click);
            // 
            // btnDecouverteRaces
            // 
            this.btnDecouverteRaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecouverteRaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.BorderSize = 0;
            this.btnDecouverteRaces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecouverteRaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecouverteRaces.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecouverteRaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnDecouverteRaces.Location = new System.Drawing.Point(582, 317);
            this.btnDecouverteRaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecouverteRaces.Name = "btnDecouverteRaces";
            this.btnDecouverteRaces.Size = new System.Drawing.Size(173, 166);
            this.btnDecouverteRaces.TabIndex = 1;
            this.btnDecouverteRaces.Text = "Découverte \r\ndes races";
            this.btnDecouverteRaces.UseVisualStyleBackColor = false;
            this.btnDecouverteRaces.Click += new System.EventHandler(this.btnDecouverteRaces_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouvelleMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.BorderSize = 0;
            this.btnNouvelleMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnNouvelleMission.Location = new System.Drawing.Point(479, 166);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(139, 129);
            this.btnNouvelleMission.TabIndex = 2;
            this.btnNouvelleMission.Text = "Nouvelle mission";
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnInfosPlanete
            // 
            this.btnInfosPlanete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfosPlanete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.BorderSize = 0;
            this.btnInfosPlanete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfosPlanete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfosPlanete.Font = new System.Drawing.Font("Orbitron", 12F);
            this.btnInfosPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnInfosPlanete.Location = new System.Drawing.Point(232, 179);
            this.btnInfosPlanete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInfosPlanete.Name = "btnInfosPlanete";
            this.btnInfosPlanete.Size = new System.Drawing.Size(112, 103);
            this.btnInfosPlanete.TabIndex = 3;
            this.btnInfosPlanete.Text = "Infos planètes";
            this.btnInfosPlanete.UseVisualStyleBackColor = false;
            this.btnInfosPlanete.Click += new System.EventHandler(this.btnInfosPlanete_Click);
            // 
            // tabPageStatistiques
            // 
            this.tabPageStatistiques.BackColor = System.Drawing.Color.Black;
            this.tabPageStatistiques.Controls.Add(this.grpStatistiques);
            this.tabPageStatistiques.Controls.Add(this.btnMenuStats);
            this.tabPageStatistiques.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistiques.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageStatistiques.Name = "tabPageStatistiques";
            this.tabPageStatistiques.Size = new System.Drawing.Size(851, 577);
            this.tabPageStatistiques.TabIndex = 2;
            // 
            // grpStatistiques
            // 
            this.grpStatistiques.Controls.Add(this.btnRechercherPlaneteMission);
            this.grpStatistiques.Controls.Add(this.cboPlanetes);
            this.grpStatistiques.Controls.Add(this.lblPlanetesMissions);
            this.grpStatistiques.Controls.Add(this.btnRechercherBudget);
            this.grpStatistiques.Controls.Add(this.btnRechercheCoequipiers);
            this.grpStatistiques.Controls.Add(this.lblLstDepenses);
            this.grpStatistiques.Controls.Add(this.cboChoixMission);
            this.grpStatistiques.Controls.Add(this.lblBudgetMissionTitre);
            this.grpStatistiques.Controls.Add(this.cboNoms);
            this.grpStatistiques.Controls.Add(this.lblCoequipiersTitre);
            this.grpStatistiques.Controls.Add(this.lblTitreStats);
            this.grpStatistiques.Location = new System.Drawing.Point(22, 16);
            this.grpStatistiques.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStatistiques.Name = "grpStatistiques";
            this.grpStatistiques.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStatistiques.Size = new System.Drawing.Size(800, 471);
            this.grpStatistiques.TabIndex = 9;
            this.grpStatistiques.TabStop = false;
            // 
            // btnRechercherPlaneteMission
            // 
            this.btnRechercherPlaneteMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherPlaneteMission.Font = new System.Drawing.Font("Orbitron Black", 10F);
            this.btnRechercherPlaneteMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnRechercherPlaneteMission.Location = new System.Drawing.Point(581, 159);
            this.btnRechercherPlaneteMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercherPlaneteMission.Name = "btnRechercherPlaneteMission";
            this.btnRechercherPlaneteMission.Size = new System.Drawing.Size(163, 30);
            this.btnRechercherPlaneteMission.TabIndex = 14;
            this.btnRechercherPlaneteMission.Text = "Rechercher";
            this.btnRechercherPlaneteMission.UseVisualStyleBackColor = true;
            // 
            // cboPlanetes
            // 
            this.cboPlanetes.BackColor = System.Drawing.Color.White;
            this.cboPlanetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlanetes.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cboPlanetes.ForeColor = System.Drawing.Color.Black;
            this.cboPlanetes.FormattingEnabled = true;
            this.cboPlanetes.IntegralHeight = false;
            this.cboPlanetes.Location = new System.Drawing.Point(587, 118);
            this.cboPlanetes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPlanetes.Name = "cboPlanetes";
            this.cboPlanetes.Size = new System.Drawing.Size(151, 24);
            this.cboPlanetes.TabIndex = 13;
            // 
            // lblPlanetesMissions
            // 
            this.lblPlanetesMissions.AutoSize = true;
            this.lblPlanetesMissions.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetesMissions.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetesMissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.lblPlanetesMissions.Location = new System.Drawing.Point(543, 88);
            this.lblPlanetesMissions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlanetesMissions.Name = "lblPlanetesMissions";
            this.lblPlanetesMissions.Size = new System.Drawing.Size(236, 20);
            this.lblPlanetesMissions.TabIndex = 12;
            this.lblPlanetesMissions.Text = "Mission(s) pour la planète :";
            this.lblPlanetesMissions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRechercherBudget
            // 
            this.btnRechercherBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercherBudget.Font = new System.Drawing.Font("Orbitron Black", 10F);
            this.btnRechercherBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnRechercherBudget.Location = new System.Drawing.Point(322, 159);
            this.btnRechercherBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercherBudget.Name = "btnRechercherBudget";
            this.btnRechercherBudget.Size = new System.Drawing.Size(163, 30);
            this.btnRechercherBudget.TabIndex = 11;
            this.btnRechercherBudget.Text = "Rechercher";
            this.btnRechercherBudget.UseVisualStyleBackColor = true;
            this.btnRechercherBudget.Click += new System.EventHandler(this.btnRechercherBudget_Click);
            // 
            // btnRechercheCoequipiers
            // 
            this.btnRechercheCoequipiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercheCoequipiers.Font = new System.Drawing.Font("Orbitron Black", 10F);
            this.btnRechercheCoequipiers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.btnRechercheCoequipiers.Location = new System.Drawing.Point(60, 159);
            this.btnRechercheCoequipiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercheCoequipiers.Name = "btnRechercheCoequipiers";
            this.btnRechercheCoequipiers.Size = new System.Drawing.Size(163, 30);
            this.btnRechercheCoequipiers.TabIndex = 10;
            this.btnRechercheCoequipiers.Text = "Rechercher";
            this.btnRechercheCoequipiers.UseVisualStyleBackColor = true;
            this.btnRechercheCoequipiers.Click += new System.EventHandler(this.btnRechercheCoequipiers_Click);
            // 
            // lblLstDepenses
            // 
            this.lblLstDepenses.AutoSize = true;
            this.lblLstDepenses.BackColor = System.Drawing.Color.Transparent;
            this.lblLstDepenses.Font = new System.Drawing.Font("Orbitron", 8F);
            this.lblLstDepenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblLstDepenses.Location = new System.Drawing.Point(325, 237);
            this.lblLstDepenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLstDepenses.Name = "lblLstDepenses";
            this.lblLstDepenses.Size = new System.Drawing.Size(0, 14);
            this.lblLstDepenses.TabIndex = 9;
            // 
            // cboChoixMission
            // 
            this.cboChoixMission.BackColor = System.Drawing.Color.White;
            this.cboChoixMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChoixMission.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cboChoixMission.ForeColor = System.Drawing.Color.Black;
            this.cboChoixMission.FormattingEnabled = true;
            this.cboChoixMission.IntegralHeight = false;
            this.cboChoixMission.Location = new System.Drawing.Point(329, 119);
            this.cboChoixMission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboChoixMission.Name = "cboChoixMission";
            this.cboChoixMission.Size = new System.Drawing.Size(151, 24);
            this.cboChoixMission.TabIndex = 5;
            // 
            // lblBudgetMissionTitre
            // 
            this.lblBudgetMissionTitre.AutoSize = true;
            this.lblBudgetMissionTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblBudgetMissionTitre.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetMissionTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.lblBudgetMissionTitre.Location = new System.Drawing.Point(299, 89);
            this.lblBudgetMissionTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudgetMissionTitre.Name = "lblBudgetMissionTitre";
            this.lblBudgetMissionTitre.Size = new System.Drawing.Size(215, 20);
            this.lblBudgetMissionTitre.TabIndex = 4;
            this.lblBudgetMissionTitre.Text = "Budget pour la mission :\r\n";
            this.lblBudgetMissionTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboNoms
            // 
            this.cboNoms.BackColor = System.Drawing.Color.White;
            this.cboNoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNoms.Font = new System.Drawing.Font("Orbitron SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cboNoms.ForeColor = System.Drawing.Color.Black;
            this.cboNoms.FormattingEnabled = true;
            this.cboNoms.IntegralHeight = false;
            this.cboNoms.Location = new System.Drawing.Point(28, 119);
            this.cboNoms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNoms.Name = "cboNoms";
            this.cboNoms.Size = new System.Drawing.Size(235, 24);
            this.cboNoms.TabIndex = 1;
            // 
            // lblCoequipiersTitre
            // 
            this.lblCoequipiersTitre.AutoSize = true;
            this.lblCoequipiersTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblCoequipiersTitre.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoequipiersTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.lblCoequipiersTitre.Location = new System.Drawing.Point(33, 69);
            this.lblCoequipiersTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoequipiersTitre.Name = "lblCoequipiersTitre";
            this.lblCoequipiersTitre.Size = new System.Drawing.Size(222, 40);
            this.lblCoequipiersTitre.TabIndex = 2;
            this.lblCoequipiersTitre.Text = "Les personnes avec qui\r\nà déjà été en mission :";
            this.lblCoequipiersTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitreStats
            // 
            this.lblTitreStats.AutoSize = true;
            this.lblTitreStats.Font = new System.Drawing.Font("Orbitron", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
            this.lblTitreStats.Location = new System.Drawing.Point(309, 20);
            this.lblTitreStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitreStats.Name = "lblTitreStats";
            this.lblTitreStats.Size = new System.Drawing.Size(183, 30);
            this.lblTitreStats.TabIndex = 0;
            this.lblTitreStats.Text = "Statistiques :";
            // 
            // btnMenuStats
            // 
            this.btnMenuStats.BackgroundImage = global::SAE24STARGATE.Properties.Resources.boutonMenu;
            this.btnMenuStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuStats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.btnMenuStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStats.Location = new System.Drawing.Point(351, 500);
            this.btnMenuStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuStats.Name = "btnMenuStats";
            this.btnMenuStats.Size = new System.Drawing.Size(150, 46);
            this.btnMenuStats.TabIndex = 8;
            this.btnMenuStats.Text = "button1";
            this.btnMenuStats.UseVisualStyleBackColor = true;
            this.btnMenuStats.Click += new System.EventHandler(this.btnMenuStats_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(841, 567);
            this.Controls.Add(this.tabMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(857, 606);
            this.MinimumSize = new System.Drawing.Size(857, 606);
            this.Name = "frmAccueil";
            this.Text = "Gestion des missions";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.grpTableauBord.ResumeLayout(false);
            this.grpInfosPlan.ResumeLayout(false);
            this.grpDecouvRaces.ResumeLayout(false);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageStatistiques.ResumeLayout(false);
            this.grpStatistiques.ResumeLayout(false);
            this.grpStatistiques.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableauBord;
        private System.Windows.Forms.Button btnDecouverteRaces;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnInfosPlanete;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.GroupBox grpTableauBord;
        private System.Windows.Forms.Button BtnInfosPlan;
        private System.Windows.Forms.Button btnNouvMission;
        private System.Windows.Forms.Button btnDecouvRaces;
        private System.Windows.Forms.Button btnTbBord;
        private System.Windows.Forms.GroupBox grpDecouvRaces;
        private System.Windows.Forms.GroupBox grpNouvMission;
        private System.Windows.Forms.GroupBox grpInfosPlan;
        private System.Windows.Forms.GroupBox grpMissionsTDB;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnFutur;
        private System.Windows.Forms.Button btnPasse;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomAlien;
        private System.Windows.Forms.ComboBox cboCouleursAliens;
        private System.Windows.Forms.TextBox txtNomAliens;
        private System.Windows.Forms.Button btnRechercherAliens;
        private System.Windows.Forms.Panel panelAliens;
        private System.Windows.Forms.Panel panelPlanetes;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPageStatistiques;
        private System.Windows.Forms.TabPage tabPageStatistiques;
        private System.Windows.Forms.Button btnMenuStats;
        private System.Windows.Forms.GroupBox grpStatistiques;
        private System.Windows.Forms.Label lblTitreStats;
        private System.Windows.Forms.ComboBox cboNoms;
        private System.Windows.Forms.Label lblCoequipiersTitre;
        private System.Windows.Forms.ComboBox cboChoixMission;
        private System.Windows.Forms.Label lblBudgetMissionTitre;
        private System.Windows.Forms.Label lblLstDepenses;
        private System.Windows.Forms.Button btnRechercheCoequipiers;
        private System.Windows.Forms.Button btnRechercherBudget;
        private System.Windows.Forms.Button btnRechercherPlaneteMission;
        private System.Windows.Forms.ComboBox cboPlanetes;
        private System.Windows.Forms.Label lblPlanetesMissions;
    }
}

