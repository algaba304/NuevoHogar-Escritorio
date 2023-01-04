using NuevoHogar_Escritorio.ModeloDTO;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NuevoHogar_Escritorio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Task<bool> IniciarSesion(string nombreUsuario, SecureString contrasenia);
        void RegistrarPerfil(UsuarioDTO usuario);
        void EditarPerfil(UsuarioDTO usuario);
        void EliminarPerfil(string estadoUsuario);
        List<UsuarioDTO> getUuarios();
    }
}
