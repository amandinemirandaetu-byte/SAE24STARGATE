using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    strDate = parties[0] + "/" + parties[1] + "/" + parties[2];
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
