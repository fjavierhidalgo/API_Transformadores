
using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application;

public class CreateInputDataCommandHandler : IRequestHandler<CreateInputDataCommand, int>
{
    private readonly IServerContext _serverContext;
    private readonly ISessionService _sessionService;

    public CreateInputDataCommandHandler(IServerContext serverContext, ISessionService sessionService)
    {
        _serverContext = serverContext;
        _sessionService = sessionService;
    }

    public async Task<int> Handle(CreateInputDataCommand request, CancellationToken cancellationToken)
    {

        
        InputData? valorLectura = await _serverContext
                .InputsData
                .FirstOrDefaultAsync(n => n.Id == request.id);

       
        if (valorLectura is null)
        {
            //Si no existe lo creamos
            InputData valorNuevo = new ();
            valorNuevo.TransformadorId = request.transformadorId ?? 0;
            valorNuevo.Project = request.project ?? "";
            valorNuevo.Customer = request.customer ?? "";
            valorNuevo.Power = request.power;
            valorNuevo.Frecc = request.frecc;
            valorNuevo.Cooling = request.cooling ?? "";
            valorNuevo.HVTapNegNumero = request.hVTapNegNumero;
            valorNuevo.HVTapNegRegulacion = request.hVTapNegRegulacion;
            valorNuevo.HVTapNegMin = request.hVTapNegMin;
            valorNuevo.HVTapPosNumero = request.hVTapPosNumero;
            valorNuevo.HVTapPosRegulacion = request.hVTapPosRegulacion;
            valorNuevo.HVTapPosMax = request.hVTapPosMax;
            valorNuevo.OilKind = request.oilKind ?? "";
           
            await _serverContext.InputsData.AddAsync(valorNuevo);
        }
        else
        {
            valorLectura.Project = request.project ?? "";
            valorLectura.Customer = request.customer ?? "";
            valorLectura.Power = request.power;
            valorLectura.Frecc = request.frecc;
            valorLectura.Cooling = request.cooling ?? "";
            valorLectura.HVTapNegNumero = request.hVTapNegNumero;
            valorLectura.HVTapNegRegulacion = request.hVTapNegRegulacion;
            valorLectura.HVTapNegMin = request.hVTapNegMin;
            valorLectura.HVTapPosNumero = request.hVTapPosNumero;
            valorLectura.HVTapPosRegulacion = request.hVTapPosRegulacion;
            valorLectura.HVTapPosMax = request.hVTapPosMax;
            valorLectura.OilKind = request.oilKind ?? "";
        }

         var res= await _serverContext.SaveChangesAndAuditAsync(_sessionService.UsuarioId);
        
        return res;

    }
}
