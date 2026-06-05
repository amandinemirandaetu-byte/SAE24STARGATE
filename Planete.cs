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
            //MessageBox.Show(nom + " param UCplanete");

            monDS = DS;
            m_nom = nom;
            //MessageBox.Show("this.m_nom : " + this.m_nom.ToString());

            if (nom == "La 9ème planète")
            {
                lblNomPlanete.Top = 80;
            }
            this.Top = top;
            this.Left = left;
            String path = "../../Resources/" + m_nom + ".png";
            //MessageBox.Show("chemin image : " + path);
            this.BackgroundImage = Image.FromFile(path);
            lblNomPlanete.Text = m_nom;

        }

        private void Planete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("nom dans planete_click : " + m_nom);
            frmPlanete frmInfosPlanete = new frmPlanete(m_nom, monDS);
            frmInfosPlanete.Show();
        }
    }
}
