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
    public class GetTransformadorByReferenciaQueryHandler : IRequestHandler<GetTransformadorByReferenciaQuery, TransformadorDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetTransformadorByReferenciaQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<TransformadorDto> Handle(GetTransformadorByReferenciaQuery request, CancellationToken cancellationToken)
        {           

            Transformador? valorLectura = await _serverContext
                .Transformadores
                .FirstOrDefaultAsync(m => m.Referencia==request.TransformadorRef);

            if (valorLectura == null)
            {
                throw new NotFoundException(nameof(Transformador), request.TransformadorRef.ToString());
            }            

            //DatosTransformadoresDto datosTransformadoresDto = new();
            
            TransformadorDto transformadorDto = new() { id = valorLectura.Id, nombre = valorLectura.Nombre ?? "", referencia=valorLectura.Referencia, detalle=valorLectura.Detalle };
            //datosTransformadoresDto.transformadores.Add(transformadorDto);
                
                        
            return transformadorDto;
        }

    }
}
