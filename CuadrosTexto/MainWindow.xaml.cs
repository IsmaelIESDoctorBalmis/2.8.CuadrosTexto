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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = mensajeNombreTextBlock;
            apellidoTextBox.Tag = mensajeApellidoTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox mensaje = (TextBox)sender;

            TextBlock ayuda = (TextBlock)mensaje.Tag;

            if (e.Key == Key.F1 && ayuda.Visibility == Visibility.Hidden)
            {
                ayuda.Visibility = Visibility.Visible;
            }
            else if(e.Key == Key.F1)
            {
                ayuda.Visibility = Visibility.Hidden;
            }

        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool intento = int.TryParse(edadTextBox.Text, out _);

            if (e.Key == Key.F2)
            {
                if (intento == false)
                {
                    errorEdadTextBlock.Visibility = Visibility.Visible;
                }
                else
                {
                    errorEdadTextBlock.Visibility = Visibility.Hidden;
                }
               
            }


        }
    }
}
