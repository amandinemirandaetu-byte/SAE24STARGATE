using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24STARGATE
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
        }

        SQLiteConnection maConnec = new SQLiteConnection();
        string connecString = @"Data Source = Stargate.db";

        bool oeilFerme = true;

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ' ')
            {
                return;
            }

            if (e.KeyChar == (char)8)
            {
                return;
            }

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnMontrerMdp_Click(object sender, EventArgs e)
        {
            if (oeilFerme)
            {
                btnMontrerMdp.BackgroundImage = Image.FromFile("../../Resources/iconeOeilOuvert.png");
                oeilFerme = false;
                txtMDP.PasswordChar = '\0';
            }
            else
            {
                btnMontrerMdp.BackgroundImage = Image.FromFile("../../Resources/iconeOeilFerme.png");
                oeilFerme = true;
                txtMDP.PasswordChar = '★';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                maConnec.ConnectionString = connecString;
                maConnec.Open();
                string sql = $"SELECT mdp FROM Admin WHERE login = '{txtLogin.Text}'";
                SQLiteCommand cmd = new SQLiteCommand(sql, maConnec);
                object resultat = cmd.ExecuteScalar();

                if (resultat != DBNull.Value && resultat != null)
                {
                    string mdpStocke = resultat.ToString();

                    bool valide = BCrypt.Net.BCrypt.Verify(txtMDP.Text, mdpStocke);

                    if (valide)
                    {
                        this.Close();
                        frmAccueil.authentifie = true;
                    }
                    else
                    {
                        MessageBox.Show("Accès refusé", "Authentification");
                        frmAccueil.authentifie = false;
                    }
                }
            }
            catch(Exception erreur)
            {
                MessageBox.Show(erreur.GetType().ToString());
            }
            finally
            {
                maConnec.Close();
            }
        }
    }
}