using NuevoHogar_Escritorio.Utils;
using NuevoHogar_Escritorio.VistaModelo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NuevoHogar_Escritorio.Vista
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        
        public InicioSesion()
        {
            var vistaModelo = new InicioSesionVistaModelo();
            DataContext = vistaModelo;
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        public void IniciarSesion(bool bandera)
        {
            if (bandera)
            {
                var vistaHomepage = new Homepage();
                vistaHomepage.Show();
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            var vistaRegistro = new RegistroUsuario();
            vistaRegistro.Show();
            this.Close();
        }
    }
}
