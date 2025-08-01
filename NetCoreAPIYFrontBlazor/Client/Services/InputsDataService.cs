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
    public interface IInputsDataService
    {
        Task<InputDataDto?> GetInPutPorReferencia(string referencia);
        Task ActualizarInput(InputDataDto dto);
    }


    public class InputsDataService : IInputsDataService
    {
                       
        private readonly IConfiguration _configuration;

        

        public InputsDataService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
     

   

        public async Task<InputDataDto?> GetInPutPorReferencia(string referencia)
        {
            InputDataDto datosResultadoDto = new();

            try
            {

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // url = "https://localhost:7162/InputData/"; 
                //API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:GetInputData"] + referencia;


                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();

                    datosResultadoDto = JsonSerializer.Deserialize<InputDataDto>(resp);

                }

            }
            catch (Exception ex)
            {
            }

            return datosResultadoDto;
        }

        public async Task ActualizarInput(InputDataDto dto)
        {
            //Realizamos una llamada a la API para actualizar el transformador

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // url = "https://localhost:7162/InputData/"; 
                //API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de  wwwroot 
                string url = _configuration["API:PostInputData"];
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
