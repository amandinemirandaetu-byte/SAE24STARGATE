using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Léo
namespace SAE24STARGATE
{
    public partial class FrmDetails : Form
    {
        DataSet m_monDS = new DataSet();
        Mission m_mission;
        Planete m_planete;
        List<DataRow> m_listeJDB = new List<DataRow>();


        int m_index;
        public FrmDetails()
        {
            InitializeComponent();
        }

        public FrmDetails(Mission mission, DataSet ds)
        {
            InitializeComponent();
            this.m_monDS = ds;
            m_mission = mission;
            
            //je sait que c'est illisible , si je le rendais lisible ça prendrais 23 variables et 3425 lignes donc je l'ai compacté un max pcq on est dans un constructeur deja biens cheum - Léo
            //Basiquement je range toutes les entrées du jdb de cette mission dans une liste triée par ordre de date croissant
            
            foreach (DataRow row in m_monDS.Tables["JournalDeBord"].Select("nomPlanete = '" + m_mission.getPlanete() + "' AND numero =" + m_mission.getNumMission().ToString()))
            {

                if (m_listeJDB.Count == 0)
                {
                    m_listeJDB.Add(row);
                }
                else if (DateTime.Parse(mission.formaterDate(row[2].ToString())) > DateTime.Parse(mission.formaterDate(m_listeJDB[m_listeJDB.Count-1][2].ToString()))) 
                {
                    m_listeJDB.Add(row);
                }
                else
                {
                    for (int i = 0; i < m_listeJDB.Count; i++)
                    {
                        if (DateTime.Parse(mission.formaterDate(row[2].ToString())) < DateTime.Parse(mission.formaterDate(m_listeJDB[i][2].ToString()))){
                            m_listeJDB.Insert(i, row);
                            i = m_listeJDB.Count;
                        }
                    }
                }
            }


            String nomPlanete = m_mission.getPlanete();
            m_planete = new Planete(nomPlanete,20,0,m_monDS);
            this.Controls.Add(m_planete);
            
            int top = -200;
            int left = -150;
            
            this.Text += m_mission.getPlanete() + m_mission.getNumMission();

            lblMission.Text += m_mission.getPlanete() + m_mission.getNumMission();
            
            String aujoudhui = mission.formaterDate(System.DateTime.Today.Date.ToShortDateString());
            if (DateTime.Parse(m_mission.getDateDepart()) > DateTime.Parse(aujoudhui))
            {
                lblDepart.ForeColor = Color.FromArgb(184, 143, 255);
                lblDepart.Text = lblDepart.Text + " prevu : " + m_mission.getDateDepart();
            }
            else
            {
                lblDepart.Text += " : " + m_mission.getDateDepart();
            }

            if (DateTime.Parse(m_mission.getDateArrivee()) > DateTime.Parse(aujoudhui))
            {
                lblRetour.ForeColor = Color.FromArgb(184, 143, 255);
                lblRetour.Text = lblRetour.Text + " prevu : " + m_mission.getDateArrivee();
            }
            else
            {
                lblRetour.Text += " : " + m_mission.getDateArrivee();
            }
            
            
            lblQuota.Text = "Quota Databaz : " + m_monDS.Tables["Mission"].Select("nomPlanete = '" + mission.getPlanete() + "' AND numero = " + m_mission.getNumMission().ToString())[0][7].ToString();
            lblBudget.Text = "Budget : " + m_monDS.Tables["Mission"].Select("nomPlanete = '" + mission.getPlanete() + "' AND numero = " + m_mission.getNumMission().ToString())[0][8].ToString() + "€";

            lblChef.Text = "Chef : " +m_mission.getChefMission();

            lblNbrMembres.Text = m_mission.getNbrMembres() + " "+ lblNbrMembres.Text;
            /*
            */
            foreach (DataRow dr in m_monDS.Tables["Capturer"].Rows)
            {
                if (dr[0].ToString() == mission.getPlanete() && dr[1].ToString() == mission.getNumMission().ToString())
                {
                    Label label = new Label();
                    String Espece = dr[2].ToString();
                    DataRow[] rows = m_monDS.Tables["Espece"].Select($"id = {Espece}");
                    if (rows.Length > 0)
                    {
                        Espece = rows[0][1].ToString();
                    }
                    label.Text = Espece + "s : \n" + dr[3].ToString();
                    label.Name = "lbl" + dr[2].ToString();
                    label.Height = 40;
                    label.Width = 180;
                    label.Left = 10;
                    label.Top = this.pnlCaptures.Controls.Count * 50;
                    label.Font = new Font("Orbitron",10); 
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    pnlCaptures.Controls.Add(label);
                }
            }
            
            foreach (UCMembre membre in m_mission.listeMembres())
            {
                if (pnlMembres.Controls.Count % 3 == 0)
                {
                    top += 210;
                    left = -180;
                }
                left += 190;
                membre.Top = top;
                membre.Left = left;
                pnlMembres.Controls.Add(membre);
            }
            this.pnlMembres.AutoScroll = true;

            this.grpJDB.Location = new System.Drawing.Point(7, 0);
        
        }
        //fonctions autos

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //gestion jdb
        
        private void btnRetour_Click(object sender, EventArgs e)
        {
            grpJDB.Visible = false;
        }

        private void btnJDB_Click(object sender, EventArgs e)
        {
            grpJDB.Visible = true;
            m_index = 0;
            if (m_listeJDB.Count > 0)
            {
                Label labelDate = new Label();
                labelDate.Text = m_mission.formaterDate(m_listeJDB[m_index][2].ToString()); //oui je triche mais la flemme de redefini formaterdate
                labelDate.Height = 40;
                labelDate.Width = 180;
                labelDate.Left = 10;
                labelDate.Font = new Font("Orbitron", 10);
                pnlPrec.Controls.Add(labelDate);

                Label labelContenu = new Label();
                labelContenu.Text =m_listeJDB[m_index][3].ToString(); //oui je triche mais la flemme de redefini formaterdate
                labelContenu.Height = 10000;
                labelContenu.Width = 180;
                labelContenu.Left = 10;
                labelContenu.Top = 60;
                labelContenu.Font = new Font("Orbitron", 10);
                pnlPrec.Controls.Add(labelContenu);

            }
            if (m_listeJDB.Count > 1)
            {
                Label labelDate = new Label();
                labelDate.Text = m_mission.formaterDate(m_listeJDB[m_index + 1][2].ToString()); //oui je triche mais la flemme de redefini formaterdate
                labelDate.Height = 40;
                labelDate.Width = 180;
                labelDate.Left = 10;
                labelDate.Font = new Font("Orbitron", 10);
                pnlCour.Controls.Add(labelDate);

                Label labelContenu = new Label();
                labelContenu.Text =m_listeJDB[m_index + 1][3].ToString(); //oui je triche mais la flemme de redefini formaterdate
                labelContenu.Height = 10000;
                labelContenu.Width = 180;
                labelContenu.Left = 10;
                labelContenu.Top = 60;
                labelContenu.Font = new Font("Orbitron", 10);
                pnlCour.Controls.Add(labelContenu);

            }
            if (m_listeJDB.Count > 2)
            {
                Label labelDate = new Label();
                labelDate.Text = m_mission.formaterDate(m_listeJDB[m_index + 2][2].ToString()); //oui je triche mais la flemme de redefini formaterdate
                labelDate.Height = 40;
                labelDate.Width = 180;
                labelDate.Left = 10;
                labelDate.Font = new Font("Orbitron", 10);
                pnlProc.Controls.Add(labelDate);

                Label labelContenu = new Label();
                labelContenu.Text =m_listeJDB[m_index + 2][3].ToString(); //oui je triche mais la flemme de redefini formaterdate
                labelContenu.Height = 10000;
                labelContenu.Width = 180;
                labelContenu.Left = 10;
                labelContenu.Top = 60;
                labelContenu.Font = new Font("Orbitron", 10);
                pnlProc.Controls.Add(labelContenu);
            }
        }
        private void btnProc_Click(object sender, EventArgs e)
        {
            if (m_listeJDB.Count > 2)
            {
                pnlCour.Controls.Clear();
                pnlPrec.Controls.Clear();
                pnlProc.Controls.Clear();

                m_index++;
                m_index = (m_index % m_listeJDB.Count + m_listeJDB.Count) % m_listeJDB.Count;

                int prec = m_index;
                int cour = (m_index +1) % m_listeJDB.Count;
                int proc = (m_index +2) % m_listeJDB.Count;

                pnlPrec.Controls.Add(creerLabelDateJDB(prec));
                pnlCour.Controls.Add(creerLabelDateJDB(cour));
                pnlProc.Controls.Add(creerLabelDateJDB(proc));
                pnlPrec.Controls.Add(creerLabelContenuJDB(prec));
                pnlCour.Controls.Add(creerLabelContenuJDB(cour));
                pnlProc.Controls.Add(creerLabelContenuJDB(proc));

            }
        }
        private void btnPrec_Click(object sender, EventArgs e)
        {
            if (m_listeJDB.Count > 2)
            {
                pnlCour.Controls.Clear();
                pnlPrec.Controls.Clear();
                pnlProc.Controls.Clear();

                m_index--;
                m_index = (m_index % m_listeJDB.Count + m_listeJDB.Count) % m_listeJDB.Count;

                int prec = (m_index - 1 + m_listeJDB.Count) % m_listeJDB.Count;
                int cour = m_index;
                int proc = (m_index + 1) % m_listeJDB.Count;

                pnlPrec.Controls.Add(creerLabelDateJDB(prec));
                pnlCour.Controls.Add(creerLabelDateJDB(cour));
                pnlProc.Controls.Add(creerLabelDateJDB(proc));
                pnlPrec.Controls.Add(creerLabelContenuJDB(prec));
                pnlCour.Controls.Add(creerLabelContenuJDB(cour));
                pnlProc.Controls.Add(creerLabelContenuJDB(proc));
            }
        }


        public Label creerLabelDateJDB(int index)
        {
            Label labelDate = new Label();
            labelDate.Text = m_mission.formaterDate(m_listeJDB[index][2].ToString()); //oui je triche mais la flemme de redefini formaterdate
            labelDate.Height = 40;
            labelDate.Width = 180;
            labelDate.Left = 10;
            labelDate.Font = new Font("Orbitron", 10);
            return labelDate;
        }
        public Label creerLabelContenuJDB(int index)
        {
            Label labelContenu = new Label();

            labelContenu.Text = m_listeJDB[index][3].ToString();
            labelContenu.Height = 10000;
            labelContenu.Width = 180;
            labelContenu.Left = 10;
            labelContenu.Top = 60;
            labelContenu.Font = new Font("Orbitron", 10);


            return labelContenu;
        
        }
        //fin gestion jdb


            //fonctions auto vides pcq j'ai la flemme de les supprimer
        private void pnlCour_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDetails_Load(object sender, EventArgs e)
        {

        }

        private void pnlPrec_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}
