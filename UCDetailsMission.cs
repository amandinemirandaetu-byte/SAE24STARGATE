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
    public partial class UCDetailsMission : UserControl
    {

        DataSet m_monDS = new DataSet();
        Mission m_mission;

        public UCDetailsMission()
        {
            InitializeComponent();
        }
        public UCDetailsMission(Mission mission , DataSet ds)
        {
            InitializeComponent();
            this.m_monDS = ds;
            m_mission = mission;
        }

        private void UCDetailsMission_Load(object sender, EventArgs e)
        {
            this.pntMission = new Planete(m_mission.getPlanete(),this.pntMission.Top,this.pntMission.Left,m_monDS);
        }

        private void planete1_Load(object sender, EventArgs e)
        {

        }
    }
}
