
using MediatR;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Server.Application.Transformadores;

public class CreateTransformadorCommand : IRequest<int>
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? referencia { get; set; }
    public string? detalle { get; set; }

}
