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

namespace STS.SiniestrosHogar.Application.Hechos.Queries.GetListaHechos
{
    public class GetListaHechosByAnioQueryHandler : IRequestHandler<GetListaHechosByAnioQuery, DatosHechosDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetListaHechosByAnioQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<DatosHechosDto> Handle(GetListaHechosByAnioQuery request, CancellationToken cancellationToken)
        {           

            List<Hecho> hechos = await _serverContext.Hechos
            .Where(m => m.Anio==request.Anio).ToListAsync();

            if (hechos == null)
            {
                throw new NotFoundException(nameof(Hecho), "");
            }            

            DatosHechosDto datosHechosDto = new();
            foreach (var hecho in hechos)
            {
              
                HechoDto hechosDto = new() { id = hecho.Id, nombre = hecho.Nombre ?? "", anio=hecho.Anio, descripcion=hecho.Detalle };
                datosHechosDto.hechos.Add(hechosDto);
              
            }
                        
            return datosHechosDto;
        }

    }
}
