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

namespace Clovek
{
    public partial class MainWindow : Window
    {
        private Person pepa;

        public MainWindow()
        {
            InitializeComponent();
            pepa = new Person("Pepa", 0);
            UpdateTextBlocks();
        }

        private void Starnout_Click(object sender, RoutedEventArgs e)
        {
            if (pepa.Vek >= 120)
            {
                MessageBox.Show("Pepa je nejstarší člověk na světě s 120 lety!", "Gratulace");
                Close();
            }
            else
            {
                pepa.Starnout(5); // Zestárni Pepu o 5 let
                UpdateTextBlocks();
            }
        }

        private void UpdateTextBlocks()
        {
            jmenoTextBlock.Text = pepa.Jmeno;
            vekTextBlock.Text = $"{pepa.Jmeno} má {pepa.Vek} roků";
        }
    }
}
