using Newtonsoft.Json;
using NuevoHogar_Escritorio.ModeloDTO;
using NuevoHogar_Escritorio.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using NuevoHogar_Escritorio.Servicios;

namespace NuevoHogar_Escritorio.Repositorios
{
    class UsuarioRepositorio : IUsuarioRepositorio
    {
        public void EditarPerfil(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public void EliminarPerfil(string estadoUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IniciarSesion(string nombreUsuario, SecureString contraseniaCifrada)
        {
            string contrasenia = new System.Net.NetworkCredential(string.Empty, contraseniaCifrada).Password;
            
            SesionService sesionService = new SesionService();
            return await sesionService.IniciarSesion(nombreUsuario, contrasenia);
            
            
        }

        public List<UsuarioDTO> getUuarios()
        {
            throw new NotImplementedException();
        }

        public void RegistrarPerfil(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }
    }
}
