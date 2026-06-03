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
            String nomPlanete = m_mission.getPlanete();
            m_planete = new Planete(nomPlanete,15,15,m_monDS);
            this.Controls.Add(m_planete);
            int top = -200;
            int left = -150;

            foreach(UCMembre membre in m_mission.listeMembres())
            {
                if (pnlMembres.Controls.Count % 5 == 0)
                {
                    top += 210;
                    left = -150;
                }
                left += 160;
                membre.Top = top;
                membre.Left = left;
                pnlMembres.Controls.Add(membre);
            }
            this.pnlMembres.AutoScroll = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
