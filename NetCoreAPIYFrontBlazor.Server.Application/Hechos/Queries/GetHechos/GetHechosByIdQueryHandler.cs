using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Application.Common;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STS.SiniestrosHogar.Application.Hechos.Queries.GetHechos
{
    public class GetHechosByIdQueryHandler : IRequestHandler<GetHechosByIdQuery, DatosHechosDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetHechosByIdQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<DatosHechosDto> Handle(GetHechosByIdQuery request, CancellationToken cancellationToken)
        {           

            Hecho? hecho = await _serverContext
                .Hechos
                .FirstOrDefaultAsync(m => m.Id==request.HechoId);

            if (hecho == null)
            {
                throw new NotFoundException(nameof(Hecho), request.HechoId.ToString());
            }            

            DatosHechosDto datosHechosDto = new();
            
            HechoDto hechosDto = new() { id = hecho.Id, nombre = hecho.Nombre ?? "", anio=hecho.Anio, descripcion=hecho.Detalle };
            datosHechosDto.hechos.Add(hechosDto);
                
                        
            return datosHechosDto;
        }

    }
}
