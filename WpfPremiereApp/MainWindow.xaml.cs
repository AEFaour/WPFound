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

namespace WpfPremiereApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // textBoxA.Text = "toto"; // A chaque fois qu'un élement est crée, alors un objet est aussi crée.
            //TextBox textBox = new TextBox();

            //gridA.Children.Add(textBox);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sldA_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void sldA_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
        // Glue code -- code behind
    }
}
