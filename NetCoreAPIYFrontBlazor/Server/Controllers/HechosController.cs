using Microsoft.AspNetCore.Mvc;
using NetCoreAPIYFrontBlazor.Server.Application.Hechos.Queries.GetHechos;
using NetCoreAPIYFrontBlazor.Shared;
using STS.SiniestrosHogar.API.Controllers.Base;
using STS.SiniestrosHogar.Application.Hechos;
using STS.SiniestrosHogar.Application.Hechos.Queries.GetHechos;
using STS.SiniestrosHogar.Application.Hechos.Queries.GetListaHechos;

namespace STS.Diversos.API.Controllers
{   
    public class HechosController : BaseController
    {
            
        [HttpGet("{hechoid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DatosHechosDto>> GetHechoId(int hechoid)
        {
            DatosHechosDto hechosDto = await Mediator.Send(new GetHechosByIdQuery(hechoid));
            return Ok(hechosDto);
        }

        [HttpGet("Anio/{anio}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DatosHechosDto>> GetHechosAnio(int anio)
        {
            DatosHechosDto hechosDto = await Mediator.Send(new GetListaHechosByAnioQuery(anio));
            return Ok(hechosDto);
        }

        [HttpGet("Lista")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DatosHechosDto>> GetHechos()
        {
            DatosHechosDto hechosDto = await Mediator.Send(new GetListaHechosByIdQuery());
            return Ok(hechosDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateHecho(CreateHechosCommand createHechosCommand)
        {
            int registros = await Mediator.Send(createHechosCommand);
            return Ok(registros);
        }


    }
}
