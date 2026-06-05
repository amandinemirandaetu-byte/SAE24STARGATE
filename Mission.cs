using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24STARGATE
{
    // idée bizzare a Léo
    public class Mission
    {
        DataSet m_monDS = new DataSet();
        DataRow m_drMission;

        String m_planete;
        int m_numMission;
        String m_dateDepart;
        String m_dateArrivee;
        String m_chef;
        int m_nbrMembres;

        public Mission(DataRow drMission, DataSet ds)
        {
            this.m_monDS = ds;
            this.m_drMission = drMission;
            DataTable tbMembres = m_monDS.Tables["Membre"];

            m_dateDepart = formaterDate(m_drMission["dateDepart"].ToString());
            m_dateArrivee = formaterDate(m_drMission["dateRetour"].ToString());
            //mission futur

            DataRow drChef = tbMembres.Select("matricule = '" + m_drMission["matriculeChef"] + "'")[0];
            m_chef = drChef["nom"] + " " + drChef["prenom"];

            m_planete = m_drMission["nomPlanete"].ToString();
            m_numMission = Int32.Parse(m_drMission["numero"].ToString());
            m_nbrMembres = Int32.Parse(m_drMission["nbMembreRequis"].ToString());

        }

        //                              Getters/Setters

        public String getPlanete() {  return m_planete; }
        public String getDateDepart() { return m_dateDepart; }
        public String getDateArrivee() { return m_dateArrivee; }
        public String getChefMission() { return m_chef; }
        public int getNumMission() { return m_numMission; }
        public int getNbrMembres() { return m_nbrMembres; }

        //fonctions customs 
        public List<UCMembre> listeMembres()
        {
            DataTable dtMembres = m_monDS.Tables["Membre"];
            DataTable dtCivils = m_monDS.Tables["Civil"];
            DataTable dtMilitaire = m_monDS.Tables["Militaire"];
            List<UCMembre> liste = new List<UCMembre>();
            List<String> idMembres= new List<String>();
            foreach (DataRow dr in m_monDS.Tables["Composer"].Rows)
            {
                string planete = dr[0].ToString();
                int mission = Convert.ToInt32(dr[1]);
                if (planete == m_planete && mission == m_numMission)
                {
                    idMembres.Add(dr[2].ToString());
                }
            }

            foreach (String id in idMembres)
            {
                UCMembre membre = new UCMembre();
                membre.setId(id);
                if (id.StartsWith("M"))
                {
                    membre.setPlaneteOrigine("???");
                    String metier = dtMilitaire.Select("matriculeMembre = '" +id+"'")[0][1].ToString();
                    membre.setMetier(metier);
                }
                else
                {
                    String PlaneteOrigine = dtCivils.Select("matriculeMembre = '" + id + "'")[0][2].ToString();
                    membre.setPlaneteOrigine(PlaneteOrigine);
                    String metier = dtCivils.Select("matriculeMembre= '" + id + "'")[0][1].ToString();
                    membre.setMetier(metier);
                }
                String nom = dtMembres.Select("matricule = '" + id + "'")[0][1].ToString();
                membre.setNom(nom);
                String prenom = dtMembres.Select("matricule= '" + id + "'")[0][2].ToString();
                membre.setPrenom(prenom);
                String dateNaissance = dtMembres.Select("matricule = '" + id + "'")[0][3].ToString();
                membre.setDateNaissance(formaterDate(dateNaissance));
                liste.Add(membre);
            }

            return liste;
        }

        public int futurOuPasse()
        {
            String aujoudhui = formaterDate(System.DateTime.Today.Date.ToShortDateString());
            if(DateTime.Parse(m_dateArrivee) < DateTime.Parse(aujoudhui))
            {
                return -1;
            }
            if(DateTime.Parse(m_dateDepart) > DateTime.Parse(aujoudhui))
            {
                return 1;
            }
            return 0;
        }


        //                              gestion format dates 
        public String formaterDate(DateTime date)
        {
            String strDate = date.Date.ToShortDateString();
            formaterDate(strDate);
            return strDate;
        }
        public String formaterDate(String strDate)
        {
            strDate = strDate.Replace("-", "/");

            String[] parties;
            if (isDate(strDate))
            {
                parties = strDate.Split('/');

                if (parties[0].Length == 4)
                {
                    strDate = parties[2] + "/" + parties[1] + "/" + parties[0];
                    return strDate;
                }
            }

            return strDate;
        }

        public bool isDate(String date)
        {
            String[] tbdate = date.Split('/');

            bool bonneLongueur = tbdate.Length == 3;
            bool annee1er = tbdate[0].Length == 4 && tbdate[1].Length == 2 && tbdate[2].Length == 2;
            bool annee3eme = tbdate[2].Length == 4 && tbdate[1].Length == 2 && tbdate[0].Length == 2;
            return bonneLongueur && (annee1er || annee3eme);

        }

    }

}
