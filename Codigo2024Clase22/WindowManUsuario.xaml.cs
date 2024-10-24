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
    /// Lógica de interacción para WindowManUsuario.xaml
    /// </summary>
    public partial class WindowManUsuario : Window
    {
        List<Usuario> usuarios = new List<Usuario>();

        public WindowManUsuario()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
           
            usuarios.Add(new Usuario{
            Nombres=txtNombre.Text,
            Apellidos=txtApellido.Text,
            Correo=txtCorreo.Text                       
            });

            
            dgUsuarios.ItemsSource = usuarios;
            dgUsuarios.Items.Refresh();

            Limpiar();

        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
        }


    }
}
