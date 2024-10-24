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
    /// Lógica de interacción para WindowUsuarios.xaml
    /// </summary>
    public partial class WindowUsuarios : Window
    {
        public WindowUsuarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario
            {
                Apellidos = "Torrico",
                Nombres = "Hugo",
                Correo = "htorrico@tecsup.edu.pe"
            });
            usuarios.Add(new Usuario
            {
                Apellidos = "Torrico",
                Nombres = "Juan",
                Correo = "jtorrico@tecsup.edu.pe"
            });
            usuarios.Add(new Usuario
            {
                Apellidos = "Torrico",
                Nombres = "Janeth",
                Correo = "ytorrico@tecsup.edu.pe"
            });

            this.dgUsuarios.ItemsSource = usuarios;
            
        }
    }
}
