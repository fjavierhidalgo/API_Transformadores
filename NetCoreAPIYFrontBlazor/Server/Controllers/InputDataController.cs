using Microsoft.AspNetCore.Mvc;
using NetCoreAPIYFrontBlazor.Server.Application;
using NetCoreAPIYFrontBlazor.Server.Domain;
using NetCoreAPIYFrontBlazor.Shared;
using STS.SiniestrosHogar.API.Controllers.Base;
using STS.SiniestrosHogar.Application;
using STS.SiniestrosHogar.Application.Transformadores.Queries;

namespace STS.Diversos.API.Controllers
{   
    public class InputDataController : BaseController
    {
            
        [HttpGet("{Referencia}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<InputDataDto>> GetRegistroRef(string Referencia)
        {
            InputDataDto lecturaDto = await Mediator.Send(new GetInputDataByReferenciaQuery(Referencia));
            return Ok(lecturaDto);
        }     


        [HttpPost]
        public async Task<IActionResult> CreateRegistro(CreateInputDataCommand createTransformadorCommand)
        {
            int registros = await Mediator.Send(createTransformadorCommand);
            return Ok(registros);
        }


    }
}
