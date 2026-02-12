using MediatR;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class GetHiVoltageByReferenciaQuery : IRequest<HiVoltageDto>
{
    public string TransformadorRef { get; set; }

    public GetHiVoltageByReferenciaQuery(string transformadorRef)
    {
        TransformadorRef = transformadorRef;
    }
}
