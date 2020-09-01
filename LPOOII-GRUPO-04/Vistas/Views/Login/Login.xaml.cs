using ClasesBase.Clases;
using Microsoft.Win32;
using System.Windows;
using Vistas.Views.Menu;

namespace Vistas.Views.Login
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            Rol admin = new Rol("1", "Administrador");
            Rol vendedor = new Rol("2", "Vendedor");

            Usuario usu_admin = new Usuario(1, "Admin", "Admin", "Administrador",admin.Rol_Codigo);
            Usuario usu_vendedor = new Usuario(2, "Vendedor", "Vendedor", "Vendedor", vendedor.Rol_Codigo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bienvenido Usuario", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);

            if (MessageBoxResult.OK == result)
            {
                MainWindow main = new MainWindow();
                main.Show();
            }
            
            
        }
    }
}
