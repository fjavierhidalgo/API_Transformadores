using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace STS.SiniestrosHogar.API.Controllers.Base;

[Route("[controller]")]
[ApiController]
//#if !DEBUG
//[Authorize(Roles = "Manager General,Manager Siniestros Diversos,ServiciosAsociados")]
//#endif
public class BaseController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

}
