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

namespace STS.SiniestrosHogar.Application
{
    public class GetInputDataByReferenciaQueryHandler : IRequestHandler<GetInputDataByReferenciaQuery, InputDataDto>    
    {
        private readonly IServerContext _serverContext;
        private readonly ISessionService _sessionService;


        public GetInputDataByReferenciaQueryHandler(IServerContext serverContext, ISessionService sessionService)
        {
            _serverContext = serverContext;
            _sessionService = sessionService;
        }

        public async Task<InputDataDto> Handle(GetInputDataByReferenciaQuery request, CancellationToken cancellationToken)
        {           

            Transformador? transformador = await _serverContext
                .Transformadores
                .FirstOrDefaultAsync(m => m.Referencia == request.TransformadorRef);

            InputData? valorLectura = await _serverContext
                .InputsData
                .Include(m => m.Transformador)
                .FirstOrDefaultAsync(m => m.Transformador.Referencia==request.TransformadorRef);

            InputDataDto resultadoDto = new() { transformadorId=transformador?.Id };

            if (valorLectura != null)
            {

                //Transformamos el objeto InputData a InputDataDto
                resultadoDto = new()
                {
                    id = valorLectura.Id,
                    transformadorId = valorLectura.TransformadorId,
                    project = valorLectura.Project,
                    customer = valorLectura.Customer,
                    power = valorLectura.Power,
                    frecc = valorLectura.Frecc,
                    cooling = valorLectura.Cooling,
                    hVTapNegNumero = valorLectura.HVTapNegNumero,
                    hVTapNegRegulacion = valorLectura.HVTapNegRegulacion,
                    hVTapNegMin = valorLectura.HVTapNegMin,
                    hVTapPosNumero = valorLectura.HVTapPosNumero,
                    hVTapPosRegulacion = valorLectura.HVTapPosRegulacion,
                    hVTapPosMax = valorLectura.HVTapPosMax,
                    oilKind = valorLectura.OilKind
                };
            }
                        
            return resultadoDto;
        }

    }
}
