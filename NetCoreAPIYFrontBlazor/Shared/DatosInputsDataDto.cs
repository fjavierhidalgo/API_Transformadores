
using NetCoreAPIYFrontBlazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Shared;


public class DatosInputsDataDto
{
    public DatosInputsDataDto()
    {
        inputsData = new List<InputDataDto>();
    }

    public List<InputDataDto> inputsData { get; set; }
}

public class InputDataDto
{
    public int id { get; set; }
    public int? transformadorId { get; set; }
    public string? project { get; set; }
    public string? customer { get; set; }
    public int? power { get; set; }
    public int? frecc { get; set; }
    public string? cooling { get; set; }
    public decimal? hVTapNegNumero { get; set; }
    public decimal? hVTapNegRegulacion { get; set; }
    public decimal? hVTapNegMin { get; set; }
    public decimal? hVTapPosNumero { get; set; }
    public decimal? hVTapPosRegulacion { get; set; }
    public decimal? hVTapPosMax { get; set; }
    public string? oilKind { get; set; }

    public string? standard { get; set; }
    public DateTime? date { get; set; }
    public string? rev { get; set; }
    public string? type { get; set; }
    public string? oFNum { get; set; }
    public string? designer { get; set; }
    public int? lineVoltHV1 { get; set; }
    public int? lineVoltGuion { get; set; }
    public int? lineVoltLV1 { get; set; }
    public int? lineVoltVacio { get; set; }
    public int? lineVoltVacio2 { get; set; }
    public string? conectionHV1 { get; set; }
    public string? conectionLV1 { get; set; }
    public string? conectionVacio2 { get; set; }
    public int? turnsLV1 { get; set; }
    public int? foils { get; set; }
    public decimal? altitude { get; set; }
    public decimal? tMax { get; set; }
    public string? hVBIL { get; set; }
    public string? lVBIL { get; set; }
    public string? hVKIND { get; set; }
    public string? lVKIND { get; set; }
    public string? nLLosses { get; set; }
    public string? llosses { get; set; }
    public string? hVMAT { get; set; }
    public string? lVMAT { get; set; }
    public int? noise { get; set; }
    public int? sC { get; set; }
    public string? noiseKP { get; set; }
    public string? noiseKHi { get; set; }
    public string? noiseKSB { get; set; }
    public string? noiseKV { get; set; }
    public int? kRBT { get; set; }
    public int? kRAB { get; set; }
}


