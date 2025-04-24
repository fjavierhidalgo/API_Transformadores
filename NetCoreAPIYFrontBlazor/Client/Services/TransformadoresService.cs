using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Client.Services
{
    public interface ITransformadoresService
    {
        Task<TransformadorDto[]> GetDatosTransformadoresLista();
    }


    public class TransformadoresService : ITransformadoresService
    {
                       
        private readonly IConfiguration _configuration;

        

        public TransformadoresService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
     

        public async Task<TransformadorDto[]> GetDatosTransformadoresLista()
        {

            DatosTransformadoresDto datosTransformadoresDto = new ();

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // url = "https://localhost:7162/Transformadores/Lista"; 
                //API:Hechos es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:Transformadores"];
               
                
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();

                    datosTransformadoresDto = JsonSerializer.Deserialize<DatosTransformadoresDto>(resp);
                    
                }

            }
            catch (Exception ex)
            {
            }

            return datosTransformadoresDto?.Transformadores?.ToArray();

        }




    }
}
