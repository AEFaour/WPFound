using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
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
using WpfBindingAvecObjetComplex.Model;

namespace WpfBindingAvecObjetComplex
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // tester le context du Binding : DataContext

            Client client = new Client { Numero = 1200, Age = 20, Nom = "nom client 1", Prenom = "prenom client 1" };

            DataContext = client;
        }
    }
}
