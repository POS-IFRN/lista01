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
    /// Interaction logic for NumeroRacionalWindow.xaml
    /// </summary>
    public partial class NumeroRacionalWindow : Window
    {
        NumeroRacional nr1 = new NumeroRacional(1, 1);
        NumeroRacional nr2 = new NumeroRacional(1, 1);
        public NumeroRacionalWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                nr1 = new NumeroRacional(int.Parse(textBox.Text), int.Parse(textBox1.Text));
                nr2 = new NumeroRacional(int.Parse(textBox_Copy.Text), int.Parse(textBox1_Copy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Mensagem: {0}", ex.Message);
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = nr1.somarRacionais(nr2).ToString();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = nr1.subtrairRacionais(nr2).ToString();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = nr1.multiplicarRacionais(nr2).ToString();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = nr1.dividirRacionais(nr2).ToString();
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            nr1.Simplificar();
            label1.Content = nr1.ToString();
        }
    }
}
