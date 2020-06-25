using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace WpfBindingAvecObjetComplex.Model
{
    class Client
    {
        // C'est une classe de type Entite --> Object-Value --> elles sont destinées à être stockées --> vie des ORM

        #region attributs (property)

        // Champs --> fields

        private int num;
        private string nom;
        private string prenom;


        #endregion attributs: // option pour mieux présenter le code
        #region Setter & getter

        // Champs --> fields

        public int GetNum()
        {
            return num;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }


        #endregion Setter & getter

        #region Propriétés

        public int Numero { set; get; }
        public string Nom { set; get; }
        public string Prenom { set; get; }

        public DateTime DateEnregistrement { set; get; }

        private int age = 23;
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 18)
                {
                    throw new Exception("Age non concerné");

                }
                else
                {
                    age = value;
                }
            }
        }
        #endregion Propriétés
    }
}
e
