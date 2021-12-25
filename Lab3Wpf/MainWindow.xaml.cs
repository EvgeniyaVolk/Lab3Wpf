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

namespace Lab3Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;

            if (fontName != null && fontName != "16" && fontName != "12")
            {
                textBox.FontSize = 14;
            }
            if (fontName != null && fontName != "16" && fontName != "14")
            {
                textBox.FontSize = 12;
            }
        }

        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold;      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations = TextDecorations.Underline;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }
    }
}

