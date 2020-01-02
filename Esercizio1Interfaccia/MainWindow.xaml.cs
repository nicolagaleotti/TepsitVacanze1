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

namespace Esercizio1Interfaccia
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double max;
            double min;
            if (n1 > n2)
            {
                max = n1;
                min = n2;
            }
            else
            {
                max = n2;
                min = n1;
            }
            double media = (n1 + n2) / 2;
            lblMax.Content = max.ToString();
            lblMin.Content = min.ToString();
            lblMedia.Content = media.ToString();
        }
    }
}
