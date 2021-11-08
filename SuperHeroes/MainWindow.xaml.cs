using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace SuperHeroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
            List<Superheroe> listaheroes = Superheroe.GetSamples();
            nombreHeroe.DataContext = listaheroes[contador];
            imagenHeroe.DataContext = listaheroes[contador];

        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (contador > 3 | contador < 0)
            {
                contador = contador;
            }
            else
            {
                contador++;
            }

        }
    }
    public class ConverFondo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Superheroe heroe = new Superheroe();
            bool fondo = heroe.Heroe;
            if (fondo)
            {
                return "PaleGreen";
            }
            else
            {
                return "IndianRed";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
