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
using System.Windows.Shapes;

namespace ExercicioInterface
{
    /// <summary>
    /// Interaction logic for CirculoWindow.xaml
    /// </summary>
    public partial class CirculoWindow : Window
    {
        Circulo c = new Circulo(3);
        public CirculoWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            c = new Circulo(double.Parse(textBoxraio.Text));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = Convert.ToString(c.getArea());
        }

        private void button1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = Convert.ToString(c.getCircunferencia());
        }
    }
}
