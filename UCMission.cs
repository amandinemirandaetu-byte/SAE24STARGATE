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

        public UCMission(String nomMission, int numMission, DateTime dateDepart, DateTime dateArrivee, String chef, int nbrMembres, String Planete)
        {
            InitializeComponent();
            lblNomMission.Text = nomMission;
            lblNumMission.Text = numMission.ToString();
            lblDateDepart.Text = dateDepart.ToString();
            lblDateArrivee.Text = dateArrivee.ToString();
            lblChefMission.Text = chef;
            lblNbrMembres.Text = nbrMembres.ToString();
            lblPlanete.Text = Planete;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDateArrivee_Click(object sender, EventArgs e)
        {

        }
    }
}
