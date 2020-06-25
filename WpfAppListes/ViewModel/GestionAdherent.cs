using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppListes.Model;

namespace WpfAppListes.ViewModel
{
    class GestionAdherent
    {
        // Une classe de traitement


        //public static List<Adherent> Adherents; // Une liste static sera partagée

        // Au lieu de List, on va utiliser les ObservableCollection qui sont en mesure de notifier 
        // tout changement de la liste 

        //public static ObservableCollection<Adherent> Adherents = new ObservableCollection<Adherent>(); // l'ObservableCollection est une liste qui est en mesure de notifier des changements 

        // Vu l'Objet Adherent va annoncer son changement, il faut qu'elle est un GET/SET et donc une propriété privée 

        private static ObservableCollection<Adherent> adherents = new ObservableCollection<Adherent>();

        public static ObservableCollection<Adherent> Adherents
        {
            get { return adherents; }
            set { adherents = value; }
        }

        // On instancie la collection dans le constructeur

        public GestionAdherent()
        {
            if (adherents == null)
            {
                adherents = new ObservableCollection<Adherent>();
            }
        }
        //méthode accessible sans instanciation 
        public static int AjouterAdherent(Adherent adherent)
        {
            adherents.Add(adherent);
            return adherents.Count;

        }
        private void InitialiserList()
        {
            int j = (new Random().Next(1, 1002));
            for (int i = 0; i < 10; i++)
            {
                Adherent a = new Adherent();
                a.Numero = j;
                a.Nom = "Nom " + j;
                a.Prenom = "Prenom " + j;
                Adherents.Add(a);
            }

        }
    }
}
