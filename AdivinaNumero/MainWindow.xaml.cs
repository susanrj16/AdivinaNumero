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

namespace AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numero = generarNumero();

        public MainWindow()
        {
            InitializeComponent();
            
        }
         
        
        public static int generarNumero()
        {
            Random random = new Random();
            int num = random.Next(100);
            return num;
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (int.Parse(numTextBox.Text) == numero)
            {
                fraseTextBox.Text = "¡Has acertado!";
            }
            else if(int.Parse(numTextBox.Text) < numero)
            {
                fraseTextBox.Text = "Te has quedado corto";
            }
            else
            {
                fraseTextBox.Text = "Te has pasado";
            }
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numTextBox.Text = "";
            fraseTextBox.Text = "";
            numero = generarNumero();
        }
    }
}
