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
                    oilKind = valorLectura.OilKind,
                    standard = valorLectura.Standard,
                    date = valorLectura.Date,
                    rev = valorLectura.Rev,
                    type = valorLectura.Type,
                    oFNum = valorLectura.OFNum,
                    designer = valorLectura.Designer,
                    lineVoltHV1 = valorLectura.LineVoltHV1,
                    lineVoltGuion = valorLectura.LineVoltGuion,
                    lineVoltLV1 = valorLectura.LineVoltLV1,
                    lineVoltVacio = valorLectura.LineVoltVacio,
                    lineVoltVacio2 = valorLectura.LineVoltVacio2,
                    conectionHV1 = valorLectura.ConectionHV1,
                    conectionLV1 = valorLectura.ConectionLV1,
                    conectionVacio2 = valorLectura.ConectionVacio2,
                    turnsLV1 = valorLectura.TurnsLV1,
                    foils = valorLectura.Foils,
                    altitude = valorLectura.Altitude,
                    tMax = valorLectura.TMax,
                    hVBIL = valorLectura.HVBIL,
                    lVBIL = valorLectura.LVBIL,
                    hVKIND = valorLectura.HVKIND,
                    lVKIND = valorLectura.LVKIND,
                    nLLosses = valorLectura.NLLosses,
                    llosses = valorLectura.Llosses,
                    hVMAT = valorLectura.HVMAT,
                    lVMAT = valorLectura.LVMAT,
                    noise = valorLectura.Noise,                
                    sC = valorLectura.SC,
                    noiseKP = valorLectura.NoiseKP,
                    noiseKHi = valorLectura.NoiseKHi,
                    noiseKSB = valorLectura.NoiseKSB,
                    noiseKV = valorLectura.NoiseKV,
                    kRBT = valorLectura.KRBT,
                    kRAB= valorLectura.KRAB
                };
            }
                        
            return resultadoDto;
        }

    }
}
