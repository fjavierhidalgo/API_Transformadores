
using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application.Transformadores;

public class CreateTransformadorCommandHandler : IRequestHandler<CreateTransformadorCommand, int>
{
    private readonly IServerContext _serverContext;
    private readonly ISessionService _sessionService;

    public CreateTransformadorCommandHandler(IServerContext serverContext, ISessionService sessionService)
    {
        _serverContext = serverContext;
        _sessionService = sessionService;
    }

    public async Task<int> Handle(CreateTransformadorCommand request, CancellationToken cancellationToken)
    {

        
        Transformador? valorLectura = await _serverContext
                .Transformadores
                .FirstOrDefaultAsync(n => n.Id == request.id);

       
        if (valorLectura is null)
        {
            //Si no existe lo creamos
            Transformador valorNuevo = new ();
            valorNuevo.Nombre = request.nombre ?? "";
            valorNuevo.Referencia = request.referencia ?? "";
            valorNuevo.Detalle = request.detalle ?? "";

            await _serverContext.Transformadores.AddAsync(valorNuevo);
        }
        else
        {
            valorLectura.Nombre = request.nombre ?? "";
            valorLectura.Referencia = request.referencia ?? "";
            valorLectura.Detalle = request.detalle ?? "";
        }

         var res= await _serverContext.SaveChangesAndAuditAsync(_sessionService.UsuarioId);
        
        return res;

    }
}
