using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Client.Services
{
    public interface IHechosService
    {
        Task<HechoDto[]> GetDatosHechosLista();
    }


    public class HechosService : IHechosService
    {
                       
        private readonly IConfiguration _configuration;

        

        public HechosService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
     

        public async Task<HechoDto[]> GetDatosHechosLista()
        {            

            DatosHechosDto datosHechosDto = new ();

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // url = "https://localhost:7162/Hechos/Lista"; 
                //API:Hechos es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:Hechos"];
               
                
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();

                    datosHechosDto = JsonSerializer.Deserialize<DatosHechosDto>(resp);
                    
                }

            }
            catch (Exception ex)
            {
            }

            return datosHechosDto?.hechos?.ToArray();

        }




    }
}
