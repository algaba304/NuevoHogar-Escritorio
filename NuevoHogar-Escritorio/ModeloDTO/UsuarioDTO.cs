using System;
using System.Collections.Generic;
using System.Text;

namespace NuevoHogar_Escritorio.ModeloDTO
{
    public class UsuarioDTO
    {
        public string IdUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Nombre { get; set; }
        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Contrasenia { get; set; }
        public string FechaNacimiento { get; set; }
        public string Biografia { get; set; }
        public string FotoPerfilUsuario { get; set; }
        public RolDTO Rol { get; set; }
        public string NombreUsuario { get; set; }
        public int ContadorReportes { get; set; }
        public string EstadoUsuario { get; set; }
        public List<EnlaceDonacionDTO> ListaDonaciones { get; set; }

        public List<EnlaceRedSocialDTO> ListaRedes { get; set; }
    }
}
