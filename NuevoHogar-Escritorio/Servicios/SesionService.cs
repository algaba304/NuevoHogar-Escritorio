using Newtonsoft.Json;
using NuevoHogar_Escritorio.ModeloDTO;
using NuevoHogar_Escritorio.Utils;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuevoHogar_Escritorio.Servicios
{
    public class SesionService
    {

        public async Task<bool> IniciarSesion(string usuario, string contrasenia)
        {

            bool esValido = true;
            RestClient cliente = new Cliente().getRestClient();
            RestRequest request = new RestRequest("api/sesion").AddQueryParameter("nombreUsuario", usuario)
                .AddParameter("contrasenia", contrasenia);
            RestResponse<UsuarioDTO> response = await cliente.ExecuteGetAsync<UsuarioDTO>(request);

            if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                esValido = false;

            }
            else if (response.IsSuccessful)
            {

                String json = response.Content;
                Cliente.Usuario = JsonConvert.DeserializeObject<UsuarioDTO>(json);

            }
            else
            {

                esValido = false;

            }
            

            return esValido;
        }

    }
}
