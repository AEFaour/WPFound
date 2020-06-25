using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppBinding2.Model
{
    class Voiture : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                AnnoncerLeChangement("Id");

            }
        }

        private string marque;

        public string Marque
        {
            get { return marque; }
            set
            {
                marque = value;
                AnnoncerLeChangement("Marque");

            }
        }




        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                AnnoncerLeChangement("Nom");

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void AnnoncerLeChangement(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));

            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }


    }
}
