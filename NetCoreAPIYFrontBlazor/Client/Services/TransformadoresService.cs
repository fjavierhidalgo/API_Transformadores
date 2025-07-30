using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using NetCoreAPIYFrontBlazor.Shared;
using System.Text;

namespace NetCoreAPIYFrontBlazor.Client.Services
{
    public interface ITransformadoresService
    {
        Task<TransformadorDto[]> GetDatosTransformadoresLista();
        Task<TransformadorDto?> GetTransformadorPorReferencia(string referencia);
        Task ActualizarTransformador(TransformadorDto dto);
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
                //API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:GetTransformadores"];
               
                
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

            return datosTransformadoresDto?.transformadores?.ToArray();

        }

        public async Task<TransformadorDto?> GetTransformadorPorReferencia(string referencia)
        {
            TransformadorDto datosTransformadorDto = new();

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // url = "https://localhost:7162/Transformadores/"; 
                //API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:GetTransformador"] + referencia;


                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();

                    datosTransformadorDto = JsonSerializer.Deserialize<TransformadorDto>(resp);

                }

            }
            catch (Exception ex)
            {
            }

            return datosTransformadorDto;
        }

        public async Task ActualizarTransformador(TransformadorDto dto)
        {
            //Realizamos una llamada a la API para actualizar el transformador

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // url = "https://localhost:7162/Transformadores/"; 
                //API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:PostTransformador"];
                // Serializar el objeto a JSON
                string jsonContent = JsonSerializer.Serialize(dto);
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                // Enviar POST
                HttpResponseMessage response = await client.PostAsync(url, httpContent);

                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
            }


        }





    }
}
