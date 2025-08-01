
using MediatR;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class CreateInputDataCommand : IRequest<int>
{
    public int id { get; set; }
    public int? transformadorId { get; set; }
    public string? project { get; set; }
    public string? customer { get; set; }
    public int? power { get; set; }
    public int? frecc { get; set; }
    public string? cooling { get; set; }
    public decimal? hVTapNegNumero { get; set; }
    public decimal? hVTapNegRegulacion { get; set; }
    public decimal? hVTapNegMin { get; set; }
    public decimal? hVTapPosNumero { get; set; }
    public decimal? hVTapPosRegulacion { get; set; }
    public decimal? hVTapPosMax { get; set; }
    public string? oilKind { get; set; }
   

}
