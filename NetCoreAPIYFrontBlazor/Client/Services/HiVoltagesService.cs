using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Text.Json;
using NetCoreAPIYFrontBlazor.Shared;
using System.Text;

namespace NetCoreAPIYFrontBlazor.Client.Services
{
    public interface IHiVoltagesService
    {
        Task<HiVoltageDto?> GetHiVoltagePorReferencia(string referencia);
        Task ActualizarHiVoltage(HiVoltageDto dto);
    }

    public class HiVoltagesService : IHiVoltagesService
    {
        private readonly IConfiguration _configuration;

        public HiVoltagesService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<HiVoltageDto?> GetHiVoltagePorReferencia(string referencia)
        {
            HiVoltageDto datosResultadoDto = new();

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // url = "https://localhost:7162/HiVoltage/"; 
                // API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de wwwroot 
                string url = _configuration["API:GetHiVoltage"] + referencia;

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();

                    datosResultadoDto = JsonSerializer.Deserialize<HiVoltageDto>(resp);
                }
            }
            catch (Exception ex)
            {
            }

            return datosResultadoDto;
        }

        public async Task ActualizarHiVoltage(HiVoltageDto dto)
        {
            // Realizamos una llamada a la API para actualizar el HiVoltage
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                // url = "https://localhost:7162/HiVoltage/"; 
                // API:url es un valor definido en el appsettings.json. En el cliente de un proyecto Blazor WebAssembly este fichero .json tiene que estar dentro de wwwroot 
                string url = _configuration["API:PostHiVoltage"];
                
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
