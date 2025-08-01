
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

}


