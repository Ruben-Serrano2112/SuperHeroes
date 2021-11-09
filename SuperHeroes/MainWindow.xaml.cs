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

    public partial class MainWindow : Window
    {
        int contador = 0;
        List<Superheroe> listaheroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = listaheroes[contador];
            

        }

        private void Image_MouseLeftButtonDownDerecha(object sender, MouseButtonEventArgs e)
        {
            if (contador!=3)
            {
                contador++;
                HeroeActual.Text = contador + "/3";
                DataContext = listaheroes[contador-1];
            }
            else
            {
                contador++;
            }

        }
        private void Image_MouseLeftButtonDownIzquierda(object sender, MouseButtonEventArgs e)
        {
            if (contador != 1)
            {
                contador--;
                HeroeActual.Text = contador + "/3";
                DataContext = listaheroes[contador-1];
            }

        }
    }
    public class ConverVisibilidad : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool fondo = (bool)value;
            if (fondo)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ConverFondo : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool fondo = (bool)value;
            if (fondo)
            {
                return Brushes.PaleGreen;
            }
            else
            {
                return Brushes.IndianRed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
