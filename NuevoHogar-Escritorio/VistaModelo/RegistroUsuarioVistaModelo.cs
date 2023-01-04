using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace NuevoHogar_Escritorio.VistaModelo
{
    class RegistroUsuarioVistaModelo
    {
        private string nombreUsuario;
        private SecureString contrasenia;
        private string nombre;
        private string direccion;
        private string fechaNacimiento;
        private string numeroTelefono;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public SecureString Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
    }
}
