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
    public class GetTransformadorByIdQueryHandler : IRequestHandler<GetTransformadorByIdQuery, DatosTransformadoresDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetTransformadorByIdQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<DatosTransformadoresDto> Handle(GetTransformadorByIdQuery request, CancellationToken cancellationToken)
        {           

            Transformador? valorLectura = await _serverContext
                .Transformadores
                .FirstOrDefaultAsync(m => m.Id==request.TransformadorId);

            if (valorLectura == null)
            {
                throw new NotFoundException(nameof(Transformador), request.TransformadorId.ToString());
            }            

            DatosTransformadoresDto datosTransformadoresDto = new();
            
            TransformadorDto transformadorDto = new() { id = valorLectura.Id, nombre = valorLectura.Nombre ?? "", referencia=valorLectura.Referencia, detalle=valorLectura.Detalle };
            datosTransformadoresDto.Transformadores.Add(transformadorDto);
                
                        
            return datosTransformadoresDto;
        }

    }
}
