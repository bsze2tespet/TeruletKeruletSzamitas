using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace TeruletKeruletSzamitas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtSideA.Text);
                double b = Convert.ToDouble(txtSideB.Text);
                double c = Convert.ToDouble(txtSideC.Text);

                if (a + b > c && a + c > b && b + c > a)
                {
                    double kerulet = a + b + c;
                    double s = kerulet / 2; // Félszélesség
                    double terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                    lblResult.Content = $"Kerület: {kerulet:F2}, Terület: {terulet:F2}";
                }
                else
                {
                    lblResult.Content = "Nem háromszög!";
                }
            }
            }
        Catch(FormatException) 
        {
            lblResult.Content = "Hibás adatok!";
        }
        }
    }
}
