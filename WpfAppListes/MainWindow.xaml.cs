using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppListes.Model;
using WpfAppListes.ViewModel;

namespace WpfAppListes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionAdherent GestionAdherent = new GestionAdherent();
        public MainWindow()
        {
            InitializeComponent();

            //DataContext =
        }

        private void ChargerImage_Click(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Fichiers tous type d'image  *.png|*.bmp|*.jepg| Autres fichiers (*.*)|*.*";
            ofd.Filter = "Fichiers images (*.png,*.bmp,*.jpeg,*.jpg)|*.png;*.bmp;*.jpeg;*.jpg|Tous les types (*.*)|*.*";


            if (ofd.ShowDialog() == true) // le user a selectionné et a choisit OK
            {
                // ofd.FileName contient alors le chemin du ficher 
                string _path = ofd.FileName; // \var : veut dire local à ce bloc --> convention

                ImgPhoto.Source = new BitmapImage(new Uri(_path));
            }
        }

        private void AjouterAdherent_Click(object sender, RoutedEventArgs e)
        {
            int _n;
            Adherent a = new Adherent();
            if (!int.TryParse(txtNumero.Text, out _n))
            {
                MessageBox.Show("Numéro incorrecte");
            }
            else
            {
                a.Numero = _n;
                a.Nom = txtNom.Text;
                a.Prenom = txtPrenom.Text;
                a.Photo = ImgPhoto.Source.ToString();

                //GestionAdherent.AjouterAdherent(a);

                string _msg = (GestionAdherent.AjouterAdherent(a) > 0 ? "Ajouté !" : "Echec de l'ajout");
                //MessageBox.Show(_msg);
            }

        }
        private void TestAccesDB()
        {
            // EFAdherentEntities --> Le conteneur d'entité du fichier edmx
            // le conteneur d'entité est gééralment appelé le DataContext dtc
            EFAdherentEntities dtc = new EFAdherentEntities();
            // pour ajouter une activité
            Activity activite = new Activity() { libelle = "Foot" };

            dtc.Activity.Add(activite);
            // sauvegarder dans la base
            int i = dtc.SaveChanges();
            string _msg = (i > 0) ? "Enregistré " : "Non enregistré";
            MessageBox.Show(_msg);

            foreach (var item in dtc.Activity)
            {
                MessageBox.Show(item.libelle);

            }

            dtc.Dispose();


        }

        private void TestDB_Click(object sender, RoutedEventArgs e)
        {
            TestAccesDB();
        }
    }
}
