using NuevoHogar_Escritorio.ModeloDTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NuevoHogar_Escritorio.Utils
{
    public class Cliente
    {
        public static UsuarioDTO Usuario { get; set; }
        private static RestClient RestClient { get; set; }

        private static Cliente instancia = new Cliente();

        public static HttpClient ClienteCompartido { get; set; }

        public static Cliente getInstancia()
        {
            return instancia;
        }

        public Cliente() { }
        
        public RestClient getRestClient()
        {
            if (RestClient == null)
            {
                var opciones = new RestClientOptions("http://localhost:8080/");
                RestClient = new RestClient(opciones);
            }

            return RestClient;
        }
        
    }
}
