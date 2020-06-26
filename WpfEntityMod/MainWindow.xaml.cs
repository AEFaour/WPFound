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
using WpfEntityMod.Model;
using WpfEntityMod.ViewModel;

namespace WpfEntityMod
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // à utiliser en cas de bug
            GestionAbonnes gestionAbonnes = new GestionAbonnes();
            DataContext = gestionAbonnes;
        }

        private void AjouterPhoto_Click(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void AjouterAdherent_Click(object sender, RoutedEventArgs e)
        {
            string _nom = txtNom.Text.Trim().ToUpper();
            string _prenom = txtPrenom.Text.Trim();
            string _Photo = imgPhoto.Source.ToString();
            activity a = new activity();
            a = (activity)cbbActivite.SelectedItem;
            adherent adherent = new adherent() { activity = a, nom = _nom, prenom = _prenom, photo = _Photo };
            GestionAbonnes.AjouterAdherent(adherent);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            adherent a = (adherent)IsbAdherent.SelectedItem;
            MessageBox.Show(a.nom + " " + a.prenom);
        }
    }
}
