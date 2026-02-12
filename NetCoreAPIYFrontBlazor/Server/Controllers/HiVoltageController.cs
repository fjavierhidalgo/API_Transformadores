using Microsoft.AspNetCore.Mvc;
using NetCoreAPIYFrontBlazor.Server.Application;
using NetCoreAPIYFrontBlazor.Shared;
using STS.SiniestrosHogar.API.Controllers.Base;

namespace STS.Diversos.API.Controllers
{
    public class HiVoltageController : BaseController
    {
        [HttpGet("{Referencia}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<HiVoltageDto>> GetRegistroRef(string Referencia)
        {
            HiVoltageDto hiVoltageDto = await Mediator.Send(new GetHiVoltageByReferenciaQuery(Referencia));
            return Ok(hiVoltageDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRegistro(CreateHiVoltageCommand createHiVoltageCommand)
        {
            int registros = await Mediator.Send(createHiVoltageCommand);
            return Ok(registros);
        }
    }
}
