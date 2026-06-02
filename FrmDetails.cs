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
    public partial class FrmDetails : Form
    {
        DataSet m_monDS = new DataSet();
        Mission m_mission;
        Planete m_planete;
        public FrmDetails()
        {
            InitializeComponent();
        }

        public FrmDetails(Mission mission, DataSet ds)
        {
            InitializeComponent();
            this.m_monDS = ds;
            m_mission = mission;
            //MessageBox.Show(m_mission.getPlanete()+" pre");
            String nomPlanete = m_mission.getPlanete();
            //MessageBox.Show(nomPlanete+ " post");
            m_planete = new Planete(m_mission.getPlanete(),15,15,m_monDS);
            this.pntMission = m_planete;
            int top = -200;
            int left = -150;
            foreach(UCMembre membre in m_mission.listeMembres())
            {
                if (pnlMembres.Controls.Count % 4 == 0) 
                {
                    top += 210;
                }
                left += 160;
                membre.Top = top;
                membre.Left = left;
                pnlMembres.Controls.Add(membre);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
