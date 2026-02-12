using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;
using NetCoreAPIYFrontBlazor.Shared;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class GetHiVoltageByReferenciaQueryHandler : IRequestHandler<GetHiVoltageByReferenciaQuery, HiVoltageDto>
{
    private readonly IServerContext _serverContext;
    private readonly ISessionService _sessionService;

    public GetHiVoltageByReferenciaQueryHandler(IServerContext serverContext, ISessionService sessionService)
    {
        _serverContext = serverContext;
        _sessionService = sessionService;
    }

    public async Task<HiVoltageDto> Handle(GetHiVoltageByReferenciaQuery request, CancellationToken cancellationToken)
    {
        Transformador? transformador = await _serverContext
            .Transformadores
            .FirstOrDefaultAsync(m => m.Referencia == request.TransformadorRef);

        HiVoltage? valorLectura = await _serverContext
            .HiVoltages
            .Include(m => m.Transformador)
            .FirstOrDefaultAsync(m => m.Transformador.Referencia == request.TransformadorRef);

        HiVoltageDto resultadoDto = new() { transformadorId = transformador?.Id };

        if (valorLectura != null)
        {
            // Transformamos el objeto HiVoltage a HiVoltageDto
            resultadoDto = new()
            {
                id = valorLectura.Id,
                transformadorId = valorLectura.TransformadorId,
                wire = valorLectura.Wire,
                stripSizeMin = valorLectura.StripSizeMin,
                stripSizeMax = valorLectura.StripSizeMax,
                parallCondGrossWireMin = valorLectura.ParallCondGrossWireMin,
                parallCondGrossWireMax = valorLectura.ParallCondGrossWireMax,
                nudeCondGrossWire = valorLectura.NudeCondGrossWire,
                nudeCond = valorLectura.NudeCond,
                parallCondMin = valorLectura.ParallCondMin,
                parallCondMax = valorLectura.ParallCondMax
            };
        }

        return resultadoDto;
    }
}
