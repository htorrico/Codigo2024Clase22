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

namespace Codigo2024Clase22
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
         lblSuma.Content =  Convert.ToInt32(txtValor1.Text) +
                            Convert.ToInt32(txtValor2.Text);

            

        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
