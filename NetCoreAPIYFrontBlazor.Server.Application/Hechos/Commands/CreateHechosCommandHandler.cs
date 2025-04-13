
using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application.Hechos.Queries.GetHechos;

public class CreateHechosCommandHandler : IRequestHandler<CreateHechosCommand, int>
{
    private readonly IServerContext _serverContext;
    private readonly ISessionService _sessionService;

    public CreateHechosCommandHandler(IServerContext serverContext, ISessionService sessionService)
    {
        _serverContext = serverContext;
        _sessionService = sessionService;
    }

    public async Task<int> Handle(CreateHechosCommand request, CancellationToken cancellationToken)
    {

        
        Hecho? hecho = await _serverContext
                .Hechos
                .FirstOrDefaultAsync(n => n.Id == request.id);

       
        if (hecho is null)
        {
            //Si no existe lo creamos
            Hecho hechoNuevo = new ();
            hechoNuevo.Anio = request.anio ?? 0;
            hechoNuevo.Nombre = request.nombre ?? "";
            hechoNuevo.Detalle = request.descripcion ?? "";

            await _serverContext.Hechos.AddAsync(hechoNuevo);
        }
        else
        {
            hecho.Anio= request.anio;
            hecho.Nombre= request.nombre;
            hecho.Detalle = request.descripcion;
        }

         var res= await _serverContext.SaveChangesAndAuditAsync(_sessionService.UsuarioId);
        
        return res;

    }
}
