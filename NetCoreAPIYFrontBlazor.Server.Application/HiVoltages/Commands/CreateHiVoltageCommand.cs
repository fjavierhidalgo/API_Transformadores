using MediatR;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class CreateHiVoltageCommand : IRequest<int>
{
    public int id { get; set; }
    public int? transformadorId { get; set; }
    public string? wire { get; set; }
    public int? stripSizeMin { get; set; }
    public int? stripSizeMax { get; set; }
    public int? parallCondGrossWireMin { get; set; }
    public int? parallCondGrossWireMax { get; set; }
    public decimal? nudeCondGrossWire { get; set; }
    public decimal? nudeCond { get; set; }
    public int? parallCondMin { get; set; }
    public int? parallCondMax { get; set; }
}
