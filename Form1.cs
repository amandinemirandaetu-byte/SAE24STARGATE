using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SAE24STARGATE
{

    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        //AMANDINE
        //permet d'initialiser le mode déconnecté de la base de données
        SQLiteConnection maConnec = new SQLiteConnection();
        string connecString = @"Data Source = Stargate.db";
        DataSet monDS = new DataSet();
        //AMANDINE
        private void frmAccueil_Load(object sender, EventArgs e)
        {

            grpTableauBord.Visible = true;

            //AMANDINE
            //permet d'initialiser le mode déconnecté de la base de données et de mettre la base de données dans monDS, le dataSet
            maConnec.ConnectionString = connecString;

            maConnec.Open();
            DataTable dtSchema = maConnec.GetSchema("Tables");

            for (int i = 0; i < dtSchema.Rows.Count; i++)
            {
                string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

                string requete = "select * from " + nomTable;
                SQLiteCommand cd = new SQLiteCommand(requete, maConnec);

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.SelectCommand = cd;

                da.Fill(monDS, nomTable);
            }

            //AMANDINE

            //AMANDINE
            //Permet de remplir un nouveau DataSet, cette fois-ci uniquement avec les couleurs distinctes d'Aliens, dans le but de remplir la cboCouleursAliens
            SQLiteDataAdapter da2 = new SQLiteDataAdapter("SELECT DISTINCT couleur FROM Espece ORDER BY couleur", maConnec);

            da2.Fill(monDS, "Couleurs");

            cboCouleursAliens.Items.Add(" ");

            foreach (DataRow ligne in monDS.Tables["Couleurs"].Rows)
            {
                cboCouleursAliens.Items.Add(ligne["couleur"].ToString());
            }


            maConnec.Close();
            //AMANDINE

            //AMANDINE

            cboCouleursAliens.SelectedIndex = 0;

            //AMANDINE

            //AMANDINE  

            int compteur = 0;

            int top = 5;
            int left = 10;

            System.Drawing.ContentAlignment ca = ContentAlignment.TopLeft;

            String armeOuInstrument = "";

            Boolean arme = false;

            String nvBvDg = "";

            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                String origine = "?";

                foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        if (origine == "?")
                        {
                            origine = ligne2["nomPlanete"].ToString() + "/";
                        }
                        else
                        {
                            origine += ligne2["nomPlanete"].ToString() + "/";
                        }
                    }
                }

                if (origine.Substring(origine.Length - 1, 1) == "/")
                {
                    origine = origine.Substring(0, origine.Length - 1);
                }

                if (origine == "?")
                {
                    ca = ContentAlignment.TopCenter;
                }


                //Permet de savoir si l'alien actuel est un allié
                foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        arme = false;
                        armeOuInstrument = ligne2["instrumentMusique"].ToString();
                        nvBvDg = ligne2["degreBienveillance"].ToString();

                        break;
                    }
                }

                //Permet de savoir si l'alien actuel est un ennemi
                foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                {
                    if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        arme = true;
                        armeOuInstrument = ligne3["typeArme"].ToString();
                        nvBvDg = ligne3["degreAgressivite"].ToString();

                        break;
                    }
                }

                SAE24STARGATE.Alien alien = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), origine, armeOuInstrument, arme, nvBvDg, left, top);

                alien.setAlignement = ca;

                panelAliens.Controls.Add(alien);

                compteur++;

                if (compteur % 4 == 0)
                {
                    left = 10;
                    top += alien.Height + 15;
                }
                else
                {
                    left += alien.Width + 15;
                }

            }

            //AMANDINE

            int top2 = 20;
            int left2 = 15;
            int compteur2 = 0;

            //AMANDINE
            // Permet de charger tous les UserControl planete


            foreach (DataRow ligne4 in monDS.Tables["Planete"].Rows)
            {
                SAE24STARGATE.Planete planete = new Planete(ligne4["nom"].ToString(), top2, left2, monDS);

                panelPlanetes.Controls.Add(planete);

                compteur2++;

                if (compteur2 % 4 == 0)
                {
                    left2 = 15;
                    top2 += planete.Height + 20;
                }
                else
                {
                    left2 += planete.Width + 20;
                }
            }

            //AMANDINE
            // Permet de remplir la cboNoms dans la page Statistiques

            monDS.Tables["Membre"].Columns.Add("prenomNom", typeof(string), "prenom + ' ' + nom");

            DataView vueTriee = monDS.Tables["Membre"].DefaultView;
            vueTriee.Sort = "prenomNom ASC";

            cboNoms.DataSource = vueTriee;
            cboNoms.DisplayMember = "prenomNom";
            cboNoms.ValueMember = "matricule";


            //AMANDINE
            // Permet de remplir la cboMission dans la page Statistiques

            monDS.Tables["Mission"].Columns.Add("MissionPlanete", typeof(string), "nomPlanete + ' ' + numero");

            foreach (DataRow ligne in monDS.Tables["Mission"].Rows)
            {
                int nbPersonnesMission = 0;

                foreach (DataRow ligne2 in monDS.Tables["Composer"].Rows)
                {
                    if (ligne2["nomPlanete"].ToString() + " " + ligne2["numeroMission"].ToString() == ligne["MissionPlanete"].ToString())
                    {
                        nbPersonnesMission++;
                    }
                }

                if (nbPersonnesMission < 10)// Temporairement inversé pour tester les stats
                {
                    cboChoixMission.Items.Add(ligne["MissionPlanete"]);
                }
            }

            //Note : y'a pas de mission qui correspond sur la DB de base, mais après avoir fait une mission test et l'avoir supprimé, mon code marche ! -Am

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
            selectBtn(tabPagePrincipal, btnTbBord);
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
            selectBtn(tabPagePrincipal, btnDecouvRaces);
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
            selectBtn(tabPagePrincipal, btnNouvMission);
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
            selectBtn(tabPagePrincipal, BtnInfosPlan);
            grpDecouvRaces.Visible = false;
            grpNouvMission.Visible = false;
            grpTableauBord.Visible = false;
            grpInfosPlan.Visible = true;
            // AMANDINE
        }

        private void txtNomAliens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // AMANDINE
            // Permet de n'autoriser que les lettres et le retour arrière, shift, espace, entrée etc... Dans la zone de texte permettant de rentrer le nom des aliens
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRechercherAliens_Click(sender, e);
            }
            // AMANDINE
        }

        private void cboCouleursAliens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // AMANDINE
            // Permet de chercher les aliens quand on appuie sur la touche Entrée
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRechercherAliens_Click(sender, e);
            }
            // AMANDINE
        }

        private void btnRechercherAliens_Click(object sender, EventArgs e)
        {
            // AMANDINE
            // Permet de chercher les aliens selon quels zones sont remplies
            if (txtNomAliens.Text == "" && cboCouleursAliens.SelectedIndex == 0)
            {
                panelAliens.Controls.Clear();
                toutAfficher(sender, e);
            }

            if (txtNomAliens.Text != "")
            {
                panelAliens.Controls.Clear();
                trierParNom(sender, e, txtNomAliens.Text);
            }

            if (cboCouleursAliens.SelectedIndex != 0)
            {
                panelAliens.Controls.Clear();
                trierParCouleur(sender, e, cboCouleursAliens.SelectedItem.ToString());
            }

            if (txtNomAliens.Text != "" && cboCouleursAliens.SelectedIndex != 0)
            {
                panelAliens.Controls.Clear();
                trierParNomEtParCouleur(sender, e, txtNomAliens.Text, cboCouleursAliens.SelectedItem.ToString());
            }
            // AMANDINE

        }




        private void trierParNom(object sender, EventArgs e, String txtRecherche)
        {
            int compteur = 0;

            int top = 5;
            int left = 10;

            System.Drawing.ContentAlignment ca = ContentAlignment.TopLeft;

            String armeOuInstrument = "";

            Boolean arme = false;

            String nvBvDg = "";

            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                if (ligne["nom"].ToString().ToUpper().Contains(txtRecherche.ToUpper()))
                {
                    String origine = "?";

                    foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            if (origine == "?")
                            {
                                origine = ligne2["nomPlanete"].ToString() + "/";
                            }
                            else
                            {
                                origine += ligne2["nomPlanete"].ToString() + "/";
                            }
                        }
                    }

                    if (origine.Substring(origine.Length - 1, 1) == "/")
                    {
                        origine = origine.Substring(0, origine.Length - 1);
                    }

                    if (origine == "?")
                    {
                        ca = ContentAlignment.TopCenter;
                    }


                    //Permet de savoir si l'alien actuel est un allié
                    foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = false;
                            armeOuInstrument = ligne2["instrumentMusique"].ToString();
                            nvBvDg = ligne2["degreBienveillance"].ToString();

                            break;
                        }
                    }

                    //Permet de savoir si l'alien actuel est un ennemi
                    foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                    {
                        if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = true;
                            armeOuInstrument = ligne3["typeArme"].ToString();
                            nvBvDg = ligne3["degreAgressivite"].ToString();

                            break;
                        }
                    }

                    SAE24STARGATE.Alien alien = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), origine, armeOuInstrument, arme, nvBvDg, left, top);

                    alien.setAlignement = ca;

                    panelAliens.Controls.Add(alien);

                    compteur++;

                    if (compteur % 4 == 0)
                    {
                        left = 10;
                        top += alien.Height + 15;
                    }
                    else
                    {
                        left += alien.Width + 15;
                    }
                }
            }
        }














        private void trierParCouleur(object sender, EventArgs e, String couleurChoisie)
        {
            int compteur = 0;

            int top = 5;
            int left = 10;

            System.Drawing.ContentAlignment ca = ContentAlignment.TopLeft;

            String armeOuInstrument = "";

            Boolean arme = false;

            String nvBvDg = "";

            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                if (ligne["couleur"].ToString().ToUpper() == couleurChoisie.ToUpper())
                {

                    String origine = "?";

                    foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            if (origine == "?")
                            {
                                origine = ligne2["nomPlanete"].ToString() + "/";
                            }
                            else
                            {
                                origine += ligne2["nomPlanete"].ToString() + "/";
                            }
                        }
                    }

                    if (origine.Substring(origine.Length - 1, 1) == "/")
                    {
                        origine = origine.Substring(0, origine.Length - 1);
                    }

                    if (origine == "?")
                    {
                        ca = ContentAlignment.TopCenter;
                    }


                    //Permet de savoir si l'alien actuel est un allié
                    foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = false;
                            armeOuInstrument = ligne2["instrumentMusique"].ToString();
                            nvBvDg = ligne2["degreBienveillance"].ToString();

                            break;
                        }
                    }

                    //Permet de savoir si l'alien actuel est un ennemi
                    foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                    {
                        if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = true;
                            armeOuInstrument = ligne3["typeArme"].ToString();
                            nvBvDg = ligne3["degreAgressivite"].ToString();

                            break;
                        }
                    }

                    SAE24STARGATE.Alien alien = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), origine, armeOuInstrument, arme, nvBvDg, left, top);

                    alien.setAlignement = ca;

                    panelAliens.Controls.Add(alien);

                    compteur++;

                    if (compteur % 4 == 0)
                    {
                        left = 10;
                        top += alien.Height + 15;
                    }
                    else
                    {
                        left += alien.Width + 15;
                    }
                }
            }
        }











        private void toutAfficher(object sender, EventArgs e)
        {
            int compteur = 0;

            int top = 5;
            int left = 10;

            System.Drawing.ContentAlignment ca = ContentAlignment.TopLeft;

            String armeOuInstrument = "";

            Boolean arme = false;

            String nvBvDg = "";

            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                String origine = "?";

                foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        if (origine == "?")
                        {
                            origine = ligne2["nomPlanete"].ToString() + "/";
                        }
                        else
                        {
                            origine += ligne2["nomPlanete"].ToString() + "/";
                        }
                    }
                }

                if (origine.Substring(origine.Length - 1, 1) == "/")
                {
                    origine = origine.Substring(0, origine.Length - 1);
                }

                if (origine == "?")
                {
                    ca = ContentAlignment.TopCenter;
                }


                //Permet de savoir si l'alien actuel est un allié
                foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                {
                    if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        arme = false;
                        armeOuInstrument = ligne2["instrumentMusique"].ToString();
                        nvBvDg = ligne2["degreBienveillance"].ToString();

                        break;
                    }
                }

                //Permet de savoir si l'alien actuel est un ennemi
                foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                {
                    if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                    {
                        arme = true;
                        armeOuInstrument = ligne3["typeArme"].ToString();
                        nvBvDg = ligne3["degreAgressivite"].ToString();

                        break;
                    }
                }

                SAE24STARGATE.Alien alien = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), origine, armeOuInstrument, arme, nvBvDg, left, top);

                alien.setAlignement = ca;

                panelAliens.Controls.Add(alien);

                compteur++;

                if (compteur % 4 == 0)
                {
                    left = 10;
                    top += alien.Height + 15;
                }
                else
                {
                    left += alien.Width + 15;
                }
            }
        }







        private void trierParNomEtParCouleur(object sender, EventArgs e, String txtRecherche, String couleurChoisie)
        {

            int compteur = 0;

            int top = 5;
            int left = 10;

            System.Drawing.ContentAlignment ca = ContentAlignment.TopLeft;

            String armeOuInstrument = "";

            Boolean arme = false;

            String nvBvDg = "";

            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                if (ligne["nom"].ToString().ToUpper().Contains(txtRecherche.ToUpper()) && ligne["couleur"].ToString().ToUpper() == couleurChoisie.ToUpper())
                {
                    String origine = "?";

                    foreach (DataRow ligne2 in monDS.Tables["Habiter"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            if (origine == "?")
                            {
                                origine = ligne2["nomPlanete"].ToString() + "/";
                            }
                            else
                            {
                                origine += ligne2["nomPlanete"].ToString() + "/";
                            }
                        }
                    }

                    if (origine.Substring(origine.Length - 1, 1) == "/")
                    {
                        origine = origine.Substring(0, origine.Length - 1);
                    }

                    if (origine == "?")
                    {
                        ca = ContentAlignment.TopCenter;
                    }


                    //Permet de savoir si l'alien actuel est un allié
                    foreach (DataRow ligne2 in monDS.Tables["Allie"].Rows)
                    {
                        if (ligne2["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = false;
                            armeOuInstrument = ligne2["instrumentMusique"].ToString();
                            nvBvDg = ligne2["degreBienveillance"].ToString();

                            break;
                        }
                    }

                    //Permet de savoir si l'alien actuel est un ennemi
                    foreach (DataRow ligne3 in monDS.Tables["Ennemi"].Rows)
                    {
                        if (ligne3["idEspece"].ToString() == ligne["id"].ToString())
                        {
                            arme = true;
                            armeOuInstrument = ligne3["typeArme"].ToString();
                            nvBvDg = ligne3["degreAgressivite"].ToString();

                            break;
                        }
                    }

                    SAE24STARGATE.Alien alien = new Alien(ligne["nom"].ToString(), ligne["couleur"].ToString(), origine, armeOuInstrument, arme, nvBvDg, left, top);

                    alien.setAlignement = ca;

                    panelAliens.Controls.Add(alien);

                    compteur++;

                    if (compteur % 4 == 0)
                    {
                        left = 10;
                        top += alien.Height + 15;
                    }
                    else
                    {
                        left += alien.Width + 15;
                    }
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPageMenu;
        }

        private void btnPageStatistiques_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPageStatistiques;
        }

        private void btnMenuStats_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabPageMenu;
        }

        private void btnRechercheCoequipiers_Click(object sender, EventArgs e)
        {

            lblCoequipiersTitre.Focus();

            string Coequipiers = "";

            List<string> missionsSelectionnees = new List<string>();

            foreach (DataRow ligne in monDS.Tables["Composer"].Rows)
            {
                if (cboNoms.SelectedValue.ToString() == ligne["matriculeMembre"].ToString())
                {
                    missionsSelectionnees.Add(ligne["numeroMission"].ToString());
                }
            }

            HashSet<string> coequipiers = new HashSet<string>();


            foreach (string mission in missionsSelectionnees)
            {
                foreach (DataRow ligne in monDS.Tables["Composer"].Rows)
                {
                    if (mission == ligne["numeroMission"].ToString())
                    {
                        foreach (DataRow ligne2 in monDS.Tables["Membre"].Rows)
                        {
                            if (ligne["matriculeMembre"].ToString() == ligne2["matricule"].ToString())
                            {
                                string nomComplet = ligne2["prenom"] + " " + ligne2["nom"] + " :  ";

                                if (ligne2["matricule"].ToString().Contains("C"))
                                {
                                    nomComplet += "Civil";
                                }

                                else if (ligne2["matricule"].ToString().Contains("M"))
                                {
                                    nomComplet += "Militaire";
                                }

                                else
                                {
                                    nomComplet += "??";
                                }

                                if (ligne2["matricule"].ToString() != cboNoms.SelectedValue.ToString())
                                {
                                    coequipiers.Add(nomComplet);
                                }
                            }
                        }
                    }
                }
            }

            if (coequipiers.Count == 0)
            {
                MessageBox.Show("Pas de coéquipiers pour " + cboNoms.Text, "Coequipiers de " + cboNoms.Text);
            }

            else
            {
                List<string> listeTriee = coequipiers.ToList();
                listeTriee.Sort();

                foreach (string nom in listeTriee)
                {
                    Coequipiers += nom + "\n";
                }

                MessageBox.Show(Coequipiers, "Coequipiers de " + cboNoms.Text);
            }
        }

        private void btnRechercherBudget_Click(object sender, EventArgs e)
        {
            if(cboChoixMission.Text == "")
            {
                MessageBox.Show("Mission nulle");
            }

            else
            {
                string resultat = "Budget initial : ";

                int budgetInitial = 0;

                int totalDepenses = 0;

                foreach (DataRow ligne in monDS.Tables["Mission"].Rows)
                {
                    if (ligne["MissionPlanete"].ToString() == cboChoixMission.Text)
                    {
                        budgetInitial = Convert.ToInt32(ligne["budget"]);
                        resultat += budgetInitial + "\n\nListe des dépenses :\n\n";
                    }
                }

                foreach (DataRow ligne in monDS.Tables["Depense"].Rows)
                {
                    if (ligne["nomPlanete"].ToString() + " " + ligne["numeroMission"].ToString() == cboChoixMission.Text)
                    {
                        foreach (DataRow ligne2 in monDS.Tables["TypeDepense"].Rows)
                        {
                            if (ligne["idTypeDepense"].ToString() == ligne2["id"].ToString())
                            {
                                resultat += ligne2["libelle"] + " : ";
                            }
                        }

                        resultat += ligne["motif"] + " le " + ligne["dateD"] + " => " + ligne["montant"] + "\n";

                        totalDepenses += Convert.ToInt32(ligne["montant"]);
                    }

                }

                resultat += "\nBudget total : " + (budgetInitial - totalDepenses).ToString();

                MessageBox.Show(resultat, "Budget pour la mission " + cboChoixMission.Text);
            }
        }
        ///Leo
        
        private void selectBtn(Control parent,Button cible)
        {
            foreach (Control item in parent.Controls)
            {
                if(item is Button btn)
                {
                    btn.FlatAppearance.BorderColor = Color.FromArgb(36, 107, 255);
                }
            }
            if (parent.Controls.Contains(cible))
            {
                cible.FlatAppearance.BorderColor = Color.FromArgb(31, 234, 204);
            }
        }
        private void btnFutur_Click(object sender, EventArgs e)
        {
            grpMissionsTDB.Controls.Clear();
            selectBtn(grpTableauBord, btnFutur);
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            grpMissionsTDB.Controls.Clear();
            selectBtn(grpTableauBord, btnPresent);
        }

        private void btnPasse_Click(object sender, EventArgs e)
        {
            grpMissionsTDB.Controls.Clear();
            selectBtn(grpTableauBord, btnPasse);
        }
    }
}
