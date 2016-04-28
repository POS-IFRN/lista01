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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ExerciciosString : Window
    {
        public ExerciciosString()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = textBox.Text.WordCount();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label.Content = textBox.Text.ReversePhrase();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = textBox.Text.GeneratePassword();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            label.Content = textBox.Text.PhraseFirstLetters();
        }
    }
}
