using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Léo
namespace SAE24STARGATE
{
    public partial class UCMembre : UserControl
    {
        String m_nom;
        String m_prenom;
        String m_dateNaissance;
        String m_travail;
        String m_planete;
        String m_id;
        public UCMembre()
        {
            InitializeComponent();
        }
        public UCMembre(String nom, String prenom, String id, String dateNaissance, String metier)
        {
            InitializeComponent();
            this.lblNom.Text = nom;
            this.lblPrenom.Text = prenom;
            this.lblId.Text = id;
            this.lblDateNaissance.Text = dateNaissance;
            this.lblMetier.Text = metier;
            this.lblPlaneteOrigine.Visible = false;
        }
        public UCMembre(String nom, String prenom, String id, String dateNaissance, String metier, String planete)
        {
            InitializeComponent();
            this.lblNom.Text = nom;
            this.lblPrenom.Text = prenom;
            this.lblId.Text = id;
            this.lblDateNaissance.Text = dateNaissance;
            this.lblMetier.Text = metier;
            this.lblPlaneteOrigine.Text = planete;
        }

        public void setNom(String nom)
        {
            this.m_nom = nom;
            this.lblNom.Text = nom;
        }
        public void setPrenom(String prenom)
        {
            this.m_prenom = prenom;
            this.lblPrenom.Text = prenom;

        }
        public void setId(String id)
        {
            this.m_id = id;
            this.lblId.Text = id;

        }
        public void setDateNaissance(String dateNaissance)
        {
            this.m_dateNaissance = dateNaissance;
            this.lblDateNaissance.Text = dateNaissance;

        }
        public void setMetier(String metier)
        {
            this.m_travail = metier;
            this.lblMetier.Text = metier;

        }
        public void setPlaneteOrigine(String planete)
        {
            this.m_planete = planete;
            this.lblPlaneteOrigine.Text = planete;
        }


        // overides 

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color couleur = Color.FromArgb(165, 255, 64);

            if (this.m_id.StartsWith("M"))
            {
                couleur = Color.FromArgb(184, 143, 255);
            }
            
            {
                using (Pen pen = new Pen(couleur, 2))
                {
                    e.Graphics.DrawRectangle(
                        pen,
                        0,
                        0,
                        this.Width - 1,
                        this.Height - 1
                    );
                }

            }

        }
        private void UCMembre_Load(object sender, EventArgs e)
        {

        }
    }
}
