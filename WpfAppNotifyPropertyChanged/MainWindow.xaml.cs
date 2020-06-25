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
using WpfAppNotifyPropertyChanged.Model;

namespace WpfAppNotifyPropertyChanged
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Utilisateur utilisateur = new Utilisateur();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = utilisateur;
        }
        private void ModifierUtilisateur()
        {
            Random random = new Random();
            int i = random.Next(1, 1001);

            utilisateur.Nom = "Nom " + i;
            utilisateur.Prenom = "Prenom " + i;
            MessageBox.Show(utilisateur.Prenom + " " + utilisateur.Nom);
        }

        private void NouveauUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            ModifierUtilisateur();
        }
    }
}
