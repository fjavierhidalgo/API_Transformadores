
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
            InputData valorNuevo = new();
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

            // Propiedades adicionales que faltaban
            valorNuevo.Standard = request.standard ?? "";
            valorNuevo.Date = request.date;
            valorNuevo.Rev = request.rev ?? "";
            valorNuevo.Type = request.type ?? "";
            valorNuevo.OFNum = request.oFNum ?? "";
            valorNuevo.Designer = request.designer ?? "";
            valorNuevo.LineVoltHV1 = request.lineVoltHV1;
            valorNuevo.LineVoltGuion = request.lineVoltGuion;
            valorNuevo.LineVoltLV1 = request.lineVoltLV1;
            valorNuevo.LineVoltVacio = request.lineVoltVacio;
            valorNuevo.LineVoltVacio2 = request.lineVoltVacio2;
            valorNuevo.ConectionHV1 = request.conectionHV1 ?? "";
            valorNuevo.ConectionLV1 = request.conectionLV1 ?? "";
            valorNuevo.ConectionVacio2 = request.conectionVacio2 ?? "";
            valorNuevo.TurnsLV1 = request.turnsLV1;
            valorNuevo.Foils = request.foils;
            valorNuevo.Altitude = request.altitude;
            valorNuevo.TMax = request.tMax;
            valorNuevo.HVBIL = request.hVBIL ?? "";
            valorNuevo.LVBIL = request.lVBIL ?? "";
            valorNuevo.HVKIND = request.hVKIND ?? "";
            valorNuevo.LVKIND = request.lVKIND ?? "";
            valorNuevo.NLLosses = request.nLLosses ?? "";
            valorNuevo.Llosses = request.llosses ?? "";
            valorNuevo.HVMAT = request.hVMAT ?? "";
            valorNuevo.LVMAT = request.lVMAT ?? "";
            valorNuevo.Noise = request.noise;
            valorNuevo.SC = request.sC;
            valorNuevo.NoiseKP = request.noiseKP ?? "";
            valorNuevo.NoiseKHi = request.noiseKHi ?? "";
            valorNuevo.NoiseKSB = request.noiseKSB ?? "";
            valorNuevo.NoiseKV = request.noiseKV ?? "";
            valorNuevo.KRBT = request.kRBT;
            valorNuevo.KRAB = request.kRAB;

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

            // Propiedades adicionales para actualización
            valorLectura.Standard = request.standard ?? "";
            valorLectura.Date = request.date;
            valorLectura.Rev = request.rev ?? "";
            valorLectura.Type = request.type ?? "";
            valorLectura.OFNum = request.oFNum ?? "";
            valorLectura.Designer = request.designer ?? "";
            valorLectura.LineVoltHV1 = request.lineVoltHV1;
            valorLectura.LineVoltGuion = request.lineVoltGuion;
            valorLectura.LineVoltLV1 = request.lineVoltLV1;
            valorLectura.LineVoltVacio = request.lineVoltVacio;
            valorLectura.LineVoltVacio2 = request.lineVoltVacio2;
            valorLectura.ConectionHV1 = request.conectionHV1 ?? "";
            valorLectura.ConectionLV1 = request.conectionLV1 ?? "";
            valorLectura.ConectionVacio2 = request.conectionVacio2 ?? "";
            valorLectura.TurnsLV1 = request.turnsLV1;
            valorLectura.Foils = request.foils;
            valorLectura.Altitude = request.altitude;
            valorLectura.TMax = request.tMax;
            valorLectura.HVBIL = request.hVBIL ?? "";
            valorLectura.LVBIL = request.lVBIL ?? "";
            valorLectura.HVKIND = request.hVKIND ?? "";
            valorLectura.LVKIND = request.lVKIND ?? "";
            valorLectura.NLLosses = request.nLLosses ?? "";
            valorLectura.Llosses = request.llosses ?? "";
            valorLectura.HVMAT = request.hVMAT ?? "";
            valorLectura.LVMAT = request.lVMAT ?? "";
            valorLectura.Noise = request.noise;
            valorLectura.SC = request.sC;
            valorLectura.NoiseKP = request.noiseKP ?? "";
            valorLectura.NoiseKHi = request.noiseKHi ?? "";
            valorLectura.NoiseKSB = request.noiseKSB ?? "";
            valorLectura.NoiseKV = request.noiseKV ?? "";
            valorLectura.KRBT = request.kRBT;
            valorLectura.KRAB = request.kRAB;
            //valorLectura.Wire = request.wire ?? "";
        }

        var res = await _serverContext.SaveChangesAndAuditAsync(_sessionService.UsuarioId);
        
        return res;
    }
}
