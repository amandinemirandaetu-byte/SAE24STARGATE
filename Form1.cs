using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24STARGATE
{

    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }
        private void frmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Tableau de Bord)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpTableauBord.Visible = true;
            // AMANDINE
        }

        private void btnDecouverteRaces_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Decouverte des Races)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpDecouvRaces.Visible = true;
            // AMANDINE
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Nouvelle Mission)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpNouvMission.Visible = true;
            // AMANDINE
        }

        private void btnInfosPlanete_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de changer de plan et de voir la tabPage principale, et d'afficher le bon groupBox (ici Infos Planètes)
            tabMenu.SelectedTab = tabPagePrincipal;
            grpInfosPlan.Visible = true;
            // AMANDINE
        }

        private void btnTbBord_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Tableau de Bord)
            grpDecouvRaces.Visible = false;
            grpInfosPlan.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = true;
            // AMANDINE
        }

        private void btnDecouvRaces_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Découverte des Races)
            grpInfosPlan.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = false;
            grpDecouvRaces.Visible = true;
            // AMANDINE
        }

        private void btnNouvMission_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Nouvelle Mission)
            grpDecouvRaces.Visible = false;
            grpInfosPlan.Visible = false;
            grpTableauBord.Visible = false;
            grpNouvMission.Visible = true;
            // AMANDINE
        }

        private void BtnInfosPlan_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de cacher toutes les groupBox qu'on veut invisibles (à défaut de savoir laquelle est actuellement visible), et d'afficher la bonne groupBox (ici Infos Planètes)
            grpDecouvRaces.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = false;
            grpInfosPlan.Visible = true;
            // AMANDINE
        }

        private void btnPasse_Click(object sender, EventArgs e)
        {

        }

        private void grpMissionsTDB_Enter(object sender, EventArgs e)
        {

        }
    }
}
