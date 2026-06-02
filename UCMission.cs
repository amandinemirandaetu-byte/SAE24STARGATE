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
    public partial class UCMission : UserControl
    {
        
        DataSet m_monDS = new DataSet();
        Mission m_mission;
        String m_planete;
        int m_numMission;
        String m_dateDepart;
        String m_dateArrivee;
        String m_chef;
        int m_nbrMembres;
        public UCMission()
        {
            InitializeComponent();
        }

        
        public UCMission(Mission mission, DataSet ds)
        {
            InitializeComponent();
            m_numMission = mission.getNumMission();
            m_dateDepart = mission.getDateDepart();
            m_dateArrivee = mission.getDateArrivee();
            m_chef = mission.getChefMission();
            m_nbrMembres = mission.getNbrMembres();
            m_planete = mission.getPlanete();
            m_monDS = ds;
            m_mission = mission;

            lblNumMission.Text = m_numMission.ToString();
            lblDateDepart.Text = m_dateDepart;
            lblDateArrivee.Text = m_dateArrivee;
            lblChefMission.Text = m_chef;
            lblNbrMembres.Text = m_nbrMembres.ToString();
            lblPlanete.Text = m_planete;
        }

        // getters/setters

        public Mission GetMission() { return this.m_mission; }


        //fonctions customs
        public UCMembre[] listeMembres()
        {
            UCMembre[] liste = new UCMembre[m_numMission];
            

            return liste;
        }


        private void btnDetails_Click(object sender, EventArgs e)
        {
            btnDetails.BackColor = Color.FromArgb(255, 0, 255);
            btnDetails.ForeColor = Color.FromArgb(0, 255,0);
            btnDetails.Text = "a venir";
            FrmDetails details = new FrmDetails(this.m_mission,this.m_monDS);
            details.ShowDialog();
            
        }
    }
}
