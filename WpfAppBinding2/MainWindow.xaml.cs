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
using WpfAppBinding2.Model;

namespace WpfAppBinding2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Voiture voiture = new Voiture();
        public MainWindow()
        {
            InitializeComponent();

            //Voiture voiture = new Voiture { Id = 1200, Marque = "Toyota", Nom = "Hilux" };


            DataContext = voiture;
            //for (int i = 0; i < 100; i++)
            //{
            //    int j = (new Random()).Next(1, 1001);
            //    voiture.Id = j;
            //    voiture.Nom = "Nom " + j;
            //    voiture.Marque = "Marque " + j;

            //    MessageBox.Show("Voiture modifiée");
            //}
        }

        private void ModifVoiture(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int i = random.Next(1, 1001);

            //Voiture voiture = new Voiture();
            voiture.Id = i;
            voiture.Nom = "Nom " + i;
            voiture.Marque = "Marque " + i;
            MessageBox.Show(voiture.Id + " " + voiture.Marque + " " + voiture.Nom);
        }
    }
}
