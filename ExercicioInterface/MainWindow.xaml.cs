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

namespace ExercicioInterface
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new CirculoWindow();
            abrir.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new NumeroRacionalWindow();
            abrir.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new NumeroComplexoWindow();
            abrir.Show();

        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new ProgressaoMatematicaWindow();
            abrir.Show();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new LojaVeiculoWindow();
            abrir.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var abrir = new ExerciciosString();
            abrir.Show();
        }
    }
}
