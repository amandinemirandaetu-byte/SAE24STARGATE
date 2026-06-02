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
    public partial class frmPlanete : Form
    {
        public frmPlanete()
        {
            InitializeComponent();
        }

        private DataSet monDS;

        public frmPlanete(String planete, DataSet DS)
        {
            InitializeComponent();

            monDS = DS;
            MessageBox.Show(planete + " param frmPlanete");
            this.Text = this.Text + " " + planete;
            pboxPlanete.BackgroundImage = Image.FromFile("../../Resources/" + planete + ".png");
            lblNomPlanete.Text = planete;

            DataRow bonneLigne = null;

            foreach(DataRow ligne in DS.Tables["Planete"].Rows)
            {
                if (ligne["nom"].ToString() == planete)
                {
                    bonneLigne = ligne;
                }
            }

            if (bonneLigne["gravite"].ToString() != "")
            {
                lblPesanteur.Text += "\n\n" + bonneLigne["gravite"].ToString() + "    g";
            }
            else
            {
                lblPesanteur.Text += "\n\n ???    g";
            }

            if (bonneLigne["temperature"].ToString() != ""){
                lblTemperaturePlanete.Text = bonneLigne["temperature"].ToString() + " °C";

                if (Convert.ToInt16(bonneLigne["temperature"]) < 0)
                {
                    lblTemperaturePlanete.ForeColor = Color.FromArgb(36, 107, 255);     // bleu
                }
                else if (Convert.ToInt16(bonneLigne["temperature"]) > 100)
                {
                    lblTemperaturePlanete.ForeColor = Color.FromArgb(235, 79, 52);      // rouge-orange
                }
                else
                {
                    lblTemperaturePlanete.ForeColor = Color.FromArgb(184, 143, 255);    // violet
                }
            }
            else
            {
                lblTemperaturePlanete.ForeColor = Color.FromArgb(31, 234, 204);         // the turquoise
                lblTemperaturePlanete.Text = "??? °C";
            }


            if (bonneLigne["dataBazON"].ToString() != "") {
                if (bonneLigne["dataBazON"].ToString() == "1")
                {
                    lblPresenceDatabaz.ForeColor = Color.Green;
                    lblPresenceDatabaz.Text = "Oui";
                }
                else if (bonneLigne["dataBazON"].ToString() == "0")
                {
                    lblPresenceDatabaz.ForeColor = Color.Red;
                    lblPresenceDatabaz.Text = "Non";
                }
                else
                {
                    lblPresenceDatabaz.ForeColor = Color.FromArgb(31, 234, 204);        // the turquoise
                    lblPresenceDatabaz.Text = "???";
                }
            }
            else
            {
                lblPresenceDatabaz.ForeColor = Color.FromArgb(31, 234, 204);            // the turquoise
                lblPresenceDatabaz.Text = "???";
            }



            int left = 50;
            int top = 325;


            foreach(DataRow ligne in monDS.Tables["Habiter"].Rows)
            {              
                if (ligne["nomPlanete"].ToString().Contains(planete))
                {

                    foreach (DataRow ligne2 in monDS.Tables["Espece"].Rows)
                    {
                        if (ligne2["id"].ToString() == ligne["idEspece"].ToString())
                        {
                            Alien alien = new Alien(ligne2["nom"].ToString(), ligne2["couleur"].ToString(), ligne["nomPlanete"].ToString(), "", false, "", left, top);
                            this.Controls.Add(alien);
                            left += alien.Width + 50;
                        }
                    }
                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
