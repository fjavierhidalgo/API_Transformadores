using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class CreateHiVoltageCommandHandler : IRequestHandler<CreateHiVoltageCommand, int>
{
    private readonly IServerContext _serverContext;
    private readonly ISessionService _sessionService;

    public CreateHiVoltageCommandHandler(IServerContext serverContext, ISessionService sessionService)
    {
        _serverContext = serverContext;
        _sessionService = sessionService;
    }

    public async Task<int> Handle(CreateHiVoltageCommand request, CancellationToken cancellationToken)
    {
        HiVoltage? valorLectura = await _serverContext
                .HiVoltages
                .FirstOrDefaultAsync(n => n.Id == request.id);

        if (valorLectura is null)
        {
            // Si no existe lo creamos
            HiVoltage valorNuevo = new();
            valorNuevo.TransformadorId = request.transformadorId ?? 0;
            valorNuevo.Wire = request.wire ?? "";
            valorNuevo.StripSizeMin = request.stripSizeMin;
            valorNuevo.StripSizeMax = request.stripSizeMax;
            valorNuevo.ParallCondGrossWireMin = request.parallCondGrossWireMin;
            valorNuevo.ParallCondGrossWireMax = request.parallCondGrossWireMax;
            valorNuevo.NudeCondGrossWire = request.nudeCondGrossWire;
            valorNuevo.NudeCond = request.nudeCond;
            valorNuevo.ParallCondMin = request.parallCondMin;
            valorNuevo.ParallCondMax = request.parallCondMax;

            await _serverContext.HiVoltages.AddAsync(valorNuevo);
        }
        else
        {
            // Actualizar el existente
            valorLectura.Wire = request.wire ?? "";
            valorLectura.StripSizeMin = request.stripSizeMin;
            valorLectura.StripSizeMax = request.stripSizeMax;
            valorLectura.ParallCondGrossWireMin = request.parallCondGrossWireMin;
            valorLectura.ParallCondGrossWireMax = request.parallCondGrossWireMax;
            valorLectura.NudeCondGrossWire = request.nudeCondGrossWire;
            valorLectura.NudeCond = request.nudeCond;
            valorLectura.ParallCondMin = request.parallCondMin;
            valorLectura.ParallCondMax = request.parallCondMax;
        }

        var res = await _serverContext.SaveChangesAndAuditAsync(_sessionService.UsuarioId);
        
        return res;
    }
}
