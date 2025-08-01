using Microsoft.AspNetCore.Mvc;
using NetCoreAPIYFrontBlazor.Server.Application.Transformadores;
using NetCoreAPIYFrontBlazor.Shared;
using STS.SiniestrosHogar.API.Controllers.Base;
using STS.SiniestrosHogar.Application.Transformadores.Queries;

namespace STS.Diversos.API.Controllers
{   
    public class TransformadoresController : BaseController
    {
            
        [HttpGet("{Referencia}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<TransformadorDto>> GetRegistroRef(string Referencia)
        {
            TransformadorDto transformadoresDto = await Mediator.Send(new GetTransformadorByReferenciaQuery(Referencia));
            return Ok(transformadoresDto);
        }     

        [HttpGet("Lista")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<DatosTransformadoresDto>> GetRegistros()
        {
            DatosTransformadoresDto transformadoresDto = await Mediator.Send(new GetListaTransformadoresByIdQuery());
            return Ok(transformadoresDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRegistro(CreateTransformadorCommand createTransformadorCommand)
        {
            int registros = await Mediator.Send(createTransformadorCommand);
            return Ok(registros);
        }


    }
}
