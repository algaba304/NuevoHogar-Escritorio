using NuevoHogar_Escritorio.Repositorios;
using NuevoHogar_Escritorio.Vista;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Windows.Input;

namespace NuevoHogar_Escritorio.VistaModelo
{
    public class InicioSesionVistaModelo : ViewModelBase
    {
        private string nombreUsuario;
        private SecureString contrasenia;
        private InicioSesion vistaInicioSesion;
        private IUsuarioRepositorio usuarioRepositorio;
        private string mensajeError;

        public string NombreUsuario
        {
            get => nombreUsuario;
            set
            {
                nombreUsuario = value;
                OnPropertyChanged("NombreUsuario");
            }
        }
        public SecureString Contrasenia
        {
            get => contrasenia;
            set
            {
                contrasenia = value;
                OnPropertyChanged(nameof(Contrasenia));
            }
        }
        public string MensajeError
        {
            get => mensajeError;
            set {
                mensajeError = value;
                OnPropertyChanged(nameof(MensajeError));
            }
        }

        public ICommand InicioSesionCommand { get; }

        public InicioSesionVistaModelo()
        {
            usuarioRepositorio = new UsuarioRepositorio();
            InicioSesionCommand = new RelayCommand(EjecutarInicioSesionCommand, PoderEjecutarInicioSesionCommand);
        }


        private bool PoderEjecutarInicioSesionCommand(object obj)
        {
            bool datoValido;

            if (NombreUsuario == null || NombreUsuario.Length < 1 || Contrasenia == null ||
                Contrasenia.Length < 8 || Contrasenia.Length > 16)
                datoValido = false;
            else
                datoValido = true;
            return datoValido;
        }

        private void EjecutarInicioSesionCommand(object obj)
        {
            var esUsuarioValido = usuarioRepositorio.IniciarSesion(NombreUsuario, Contrasenia);
            if (esUsuarioValido.Result)
            {
                vistaInicioSesion.IniciarSesion(true);
            }
            else
            {
                MensajeError = "Usuario o contraseña incorrecto";
            }
        }
    }
}
