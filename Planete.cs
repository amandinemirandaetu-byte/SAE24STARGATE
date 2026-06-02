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
    public partial class Planete : UserControl
    {
        public Planete()
        {
            InitializeComponent();
        }

        private DataSet monDS;
        private String m_nom="";
        public Planete(String nom, int top, int left, DataSet DS)
        {
            InitializeComponent();
            MessageBox.Show(nom + " param UCplanete");

            monDS = DS;
            this.m_nom = nom;

            if (nom == "La 9ème planète")
            {
                lblNomPlanete.Top = 80;
            }
            this.Top = top;
            this.Left = left;
            String path = "../../Resources/" + m_nom + ".png";
            this.BackgroundImage = Image.FromFile(path);
            lblNomPlanete.Text = m_nom;

        }

        private void Planete_Click(object sender, EventArgs e)
        {
            frmPlanete frmInfosPlanete = new frmPlanete(this.m_nom, monDS);
            frmInfosPlanete.Show();
        }
    }
}
