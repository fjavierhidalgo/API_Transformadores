
using MediatR;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Server.Application.Hechos.Queries.GetHechos;

public class CreateHechosCommand : IRequest<int>
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public int? anio { get; set; }
    public string? descripcion { get; set; }

}
