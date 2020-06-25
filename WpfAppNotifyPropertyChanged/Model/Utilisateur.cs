using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNotifyPropertyChanged.Model
{
    class Utilisateur : INotifyPropertyChanged
    {
        // public int Id {get; set; }
        #region attributs
        // Utilisation du field private car on doit annoncer son changement

        //nom
        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                Notifier("Nom");

            }
        }

        //prenom
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                Notifier("Prenom");

            }
        }

        private void Notifier(string v)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
            // y a-t-il des souscripteurs : if event not null
            if (PropertyChanged != null)
            {
                //Alors annoncer le changement aux souscripteurs
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

}
