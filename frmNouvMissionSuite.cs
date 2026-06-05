using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SAE24STARGATE.frmAccueil;

namespace SAE24STARGATE
{
    public partial class frmNouvMissionSuite : Form
    {
        DataSet monDS;
        SQLiteConnection maConnec;
        string chefMission = "";
        List<ItemCombo> membresMatricules = new List<ItemCombo>();
        List<ItemCombo> objectifsCapture = new List<ItemCombo>();
        List<string> matricules;
        List<idEnnemiNbCapture> idEspecesNbCaptures;
        string nomPlanete;
        int indexMission;
        int membresAjoutes = 0;
        int membresRequis;
        public frmNouvMissionSuite(SQLiteConnection connec, DataSet ds, string chef, string planete, int index, int mbmRequis)
        {
            InitializeComponent();
            maConnec = connec;
            monDS = ds;
            chefMission = chef;
            matricules = new List<string>();
            idEspecesNbCaptures = new List<idEnnemiNbCapture>();
            nomPlanete = planete;
            indexMission = index;
            membresRequis = mbmRequis;
        } 

        private void frmNouvMissionSuite_Load(object sender, EventArgs e)
        {
            lblAffectationMembre.Text += " " + membresRequis;

            foreach(DataRow ligne in monDS.Tables["Membre"].Rows)
            {
                string resultat = "";
                resultat += ligne["nom"].ToString() + " " + ligne["prenom"].ToString() + " - ";
                if (ligne["matricule"].ToString().Contains("C"))
                {
                    resultat += "Civil : ";
                    foreach (DataRow ligne2 in monDS.Tables["Civil"].Rows)
                    {
                        if (ligne["matricule"].ToString() == ligne2["matriculeMembre"].ToString())
                        {
                            resultat += ligne2["Specialite"];
                        }
                    }
                }
                else if (ligne["matricule"].ToString().Contains("M"))
                {
                    resultat += "Militaire : ";
                    foreach (DataRow ligne2 in monDS.Tables["Militaire"].Rows)
                    {
                        if (ligne["matricule"].ToString() == ligne2["matriculeMembre"].ToString())
                        {
                            resultat += ligne2["grade"];
                        }
                    }
                }

                membresMatricules.Add(new ItemCombo
                {
                    Texte = resultat,
                    Valeur = ligne["matricule"].ToString()
                });
            }

            cboChoixMembre.DataSource = membresMatricules;
            cboChoixMembre.DisplayMember = "Texte";
            cboChoixMembre.ValueMember = "Valeur";

            txtMembresMission.Text += chefMission + "\r\n";


            foreach (DataRow ligne in monDS.Tables["Espece"].Rows)
            {
                string resultat = "";
                foreach (DataRow ligne2 in monDS.Tables["Ennemi"].Rows)
                {
                    if (ligne["id"].ToString() == ligne2["idEspece"].ToString())
                    {
                        resultat += ligne["nom"].ToString() + " - " + ligne["couleur"].ToString();

                        objectifsCapture.Add(new ItemCombo
                        {
                            Texte = resultat,
                            Valeur = ligne2["idEspece"].ToString()
                        });
                    }
                }
            }

            cboAliens.DataSource = objectifsCapture;
            cboAliens.DisplayMember = "Texte";
            cboAliens.ValueMember = "Valeur";
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            if(cboChoixMembre.Text != "" && !(txtMembresMission.Text.Contains(cboChoixMembre.Text)))
            {
                txtMembresMission.Text += cboChoixMembre.Text + "\r\n";
                matricules.Add(cboChoixMembre.SelectedValue.ToString());
                membresAjoutes++;
                if(membresRequis - membresAjoutes >= 0)
                {
                    lblAffectationMembre.Text = lblAffectationMembre.Text.Substring(0, lblAffectationMembre.Text.Length - 1);
                    lblAffectationMembre.Text += (membresRequis - membresAjoutes);
                }
            } 
        }

        private void btnValiderMembre_Click(object sender, EventArgs e)
        {
            if(txtMembresMission.Text != "" && membresAjoutes >= membresRequis)
            {
                maConnec.ConnectionString = @"Data Source = Stargate.db";
                maConnec.Open();

                foreach (string membre in matricules)
                {
                    try
                    {
                        string requete = @"insert into Composer([nomPlanete], [numeroMission], [matriculeMembre])
                                           values('" + nomPlanete + "', '" + indexMission + "', '" + membre + "')";

                        SQLiteCommand cd = new SQLiteCommand(requete, maConnec);

                        cd.ExecuteNonQuery();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        
                    }
                }

                MessageBox.Show("Membres bien insérés dans la base de données !");

                btnAjouterMembre.Click -= btnAjouterMembre_Click;
                btnRetirerMembre.Click -= btnRetirerMembre_Click;
                btnValiderMembre.Click -= btnValiderMembre_Click;
                btnAjouterMembre.ForeColor = Color.FromArgb(36, 107, 255);
                btnRetirerMembre.ForeColor = Color.FromArgb(36, 107, 255);
                btnValiderMembre.ForeColor = Color.FromArgb(36, 107, 255);
                txtMembresMission.ForeColor = Color.FromArgb(36, 107, 255);
                lblAffectationMembre.ForeColor = Color.FromArgb(36, 107, 255);

                pnlObjectifCapture.Visible = true;

                monDS.Clear();

                DataTable dtSchema = maConnec.GetSchema("Tables");

                for (int i = 0; i < dtSchema.Rows.Count; i++)
                {
                    string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

                    string requete2 = "select * from " + nomTable;
                    SQLiteCommand cd2 = new SQLiteCommand(requete2, maConnec);

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = cd2;

                    da.Fill(monDS, nomTable);
                }

                maConnec.Close();
            }

            else
            {
                MessageBox.Show("Veuillez ajouter plus de membres pour continuer !");
            }
        }

        private void btnRetirerMembre_Click(object sender, EventArgs e)
        {
            var lignes = txtMembresMission.Lines.ToList();

            if (lignes.Count == 0)
                return;

            // Si aucune sélection
            if (string.IsNullOrWhiteSpace(txtMembresMission.SelectedText))
                return;

            // Trouver la ligne sélectionnée
            string selection = txtMembresMission.SelectedText;
            string ligneASupprimer = lignes.FirstOrDefault(l => l.Contains(selection));

            if (ligneASupprimer == null)
                return;

            // Protection du chef (ligne 0)
            if (lignes.IndexOf(ligneASupprimer) == 0)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer le chef de mission.");
                return;
            }

            lignes.Remove(ligneASupprimer);
            txtMembresMission.Lines = lignes.ToArray();

            matricules.RemoveAll(m => ligneASupprimer.Contains(m));

            membresAjoutes--;
            if (membresRequis - membresAjoutes >= 0)
            {
                lblAffectationMembre.Text = lblAffectationMembre.Text.Substring(0, lblAffectationMembre.Text.Length - 1);
                lblAffectationMembre.Text += (membresRequis - membresAjoutes);
            }
        }

        private void btnAjouterObjectifCapture_Click(object sender, EventArgs e)
        {
            if (cboAliens.Text != "" && !(txtResumeObjectifs.Text.Contains(cboAliens.Text)) && nbrAliensCapture.Value != 0)
            {
                txtResumeObjectifs.Text += cboAliens.Text + "--> objectif de capture(s) : " + nbrAliensCapture.Value.ToString() + "\r\n";
                idEspecesNbCaptures.Add(new idEnnemiNbCapture
                {
                    idEnnemi = Convert.ToInt32(cboAliens.SelectedValue),
                    nbCapture = Convert.ToInt32(nbrAliensCapture.Value)
                });
            }
        }

        private void btnRetirerObjectif_Click(object sender, EventArgs e)
        {
            var lignes = txtResumeObjectifs.Lines.ToList();

            if (lignes.Count == 0) return;
            if (string.IsNullOrWhiteSpace(txtResumeObjectifs.SelectedText)) return;

            string selection = txtResumeObjectifs.SelectedText;
            string ligneASupprimer = lignes.FirstOrDefault(l => l.Contains(selection));

            if (ligneASupprimer == null) return;

            lignes.Remove(ligneASupprimer);
            txtResumeObjectifs.Lines = lignes.ToArray();

            ItemCombo itemConcerne = objectifsCapture.FirstOrDefault(o => ligneASupprimer.Contains(o.Texte));

            if (itemConcerne == null) return;

            idEspecesNbCaptures.RemoveAll(m => m.idEnnemi == Convert.ToInt32(itemConcerne.Valeur));
        }

        private void btnValiderObjectifs_Click(object sender, EventArgs e)
        {
            if (txtResumeObjectifs.Text != "")
            {
                maConnec.ConnectionString = @"Data Source = Stargate.db";
                maConnec.Open();

                foreach(idEnnemiNbCapture paire in idEspecesNbCaptures)
                {
                    try
                    {
                        string requete = @"insert into ObjectifCapture([nomPlanete], [numeroMission], [idEspeceEnnemi], [objectif])
                                           values('" + nomPlanete + "', '" + indexMission + "', '" + paire.idEnnemi + "', '" + paire.nbCapture + "')";

                        SQLiteCommand cd = new SQLiteCommand(requete, maConnec);

                        cd.ExecuteNonQuery();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                    }
                }

                MessageBox.Show("Informations bien ajoutées dans la base de données !");

                btnAjouterObjectifCapture.ForeColor = Color.FromArgb(36, 107, 255);
                btnRetirerObjectif.ForeColor = Color.FromArgb(36, 107, 255);
                btnValiderObjectifs.ForeColor = Color.FromArgb(36, 107, 255);
                txtResumeObjectifs.ForeColor = Color.FromArgb(36, 107, 255);
                lblObjectifsCaptures.ForeColor = Color.FromArgb(36, 107, 255);

                monDS.Clear();

                DataTable dtSchema = maConnec.GetSchema("Tables");

                for (int i = 0; i < dtSchema.Rows.Count; i++)
                {
                    string nomTable = dtSchema.Rows[i]["TABLE_NAME"].ToString();

                    string requete2 = "select * from " + nomTable;
                    SQLiteCommand cd2 = new SQLiteCommand(requete2, maConnec);

                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da.SelectCommand = cd2;

                    da.Fill(monDS, nomTable);
                }

                maConnec.Close();

                this.Close();
            }
        }
    }
}
