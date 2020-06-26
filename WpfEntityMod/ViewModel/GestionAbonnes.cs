using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEntityMod.Model;

namespace WpfEntityMod.ViewModel
{
    class GestionAbonnes : IDisposable
    //Permettre de gérer les pools de connexion à ka base de données 
    {
        #region Propriété
        private static ObservableCollection<adherent> adherents;

        private static adherentEntities dtc;

        public static ObservableCollection<adherent> Adherents
        {
            get { return adherents; }
            set { adherents = value; }
        }

        public static ObservableCollection<activity> activities;
        public static ObservableCollection<activity> Activities
        {
            get { return activities; }
            set { activities = value; }
        }
        #endregion Propriété
        #region Constructeur
        public GestionAbonnes()
        {
            // Acces à la base pour récupérer les adhérents pour cela a besoin du Conteneur d'entités

            //adherentEntities dtc = new adherentEntities();

            //dtc.Dispose(); // à la fin de l'utilisation

            //using (dtc)
            //{
            if (dtc == null)
            {
                dtc = new adherentEntities(); // Singleton
            }
            if (adherents == null)
            {
                // charger à partir de la bases de données
                adherents = new ObservableCollection<adherent>(dtc.adherent);

            }

            if (activities == null)
            {
                // charger à partir de la bases de données
                activities = new ObservableCollection<activity>(dtc.activity);

            }

        }// dispose automatique ... l'utilisation du using permet de faire un Dispose automatique



        #endregion Constructeur
        #region Méthodes

        public static int AjouterAdherent(adherent a)
        {
            dtc.adherent.Add(a);
            int i = dtc.SaveChanges();// i = -1 si échec -- met à jour la base
            if (i > 0)
            {
                adherents.Add(a); // Si ok, on 
            }
            return i;
        }
        public List<adherent> RechercherParCritere(string critere)
        {
            return null;
        }

        public void Dispose()
        {
            dtc.Dispose();
        }
        //Ensemble de méthodes pour gérer les adherents
        #endregion Méthodes
    }


}

