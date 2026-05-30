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
        public UCMission()
        {
            InitializeComponent();
        }

        public UCMission(String Planete, int numMission, String dateDepart, String dateArrivee, String chef, int nbrMembres)
        {
            InitializeComponent();
            lblNumMission.Text = numMission.ToString();
            lblDateDepart.Text = dateDepart.ToString();
            lblDateArrivee.Text = dateArrivee.ToString();
            lblChefMission.Text = chef;
            lblNbrMembres.Text = nbrMembres.ToString();
            lblPlanete.Text = Planete;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            btnDetails.BackColor = Color.FromArgb(255, 0, 255);
            btnDetails.ForeColor = Color.FromArgb(0, 255,0);
            btnDetails.Text = "a venir";
        }
    }
}
