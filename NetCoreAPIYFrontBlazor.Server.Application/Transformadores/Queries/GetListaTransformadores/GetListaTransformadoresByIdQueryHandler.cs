
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

namespace STS.SiniestrosHogar.Application.Transformadores.Queries
{
    public class GetListaTransformadoresByIdQueryHandler : IRequestHandler<GetListaTransformadoresByIdQuery, DatosTransformadoresDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetListaTransformadoresByIdQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<DatosTransformadoresDto> Handle(GetListaTransformadoresByIdQuery request, CancellationToken cancellationToken)
        {           

            List<Transformador> datosLeidos = await _serverContext
                .Transformadores.ToListAsync();
            //.Where(m => m.GarantiaId==request.GarantiaId).ToListAsync();

            if (datosLeidos == null)
            {
                throw new NotFoundException(nameof(Transformador), "");
            }            

            DatosTransformadoresDto datosTransformadoresDto = new();
            foreach (var datoLeido in datosLeidos)
            {
              
                TransformadorDto transformadorDto = new() { id = datoLeido.Id, nombre = datoLeido.Nombre ?? "", referencia=datoLeido.Referencia, detalle=datoLeido.Detalle };
                datosTransformadoresDto.transformadores.Add(transformadorDto);
              
            }
                        
            return datosTransformadoresDto;
        }

    }
}
