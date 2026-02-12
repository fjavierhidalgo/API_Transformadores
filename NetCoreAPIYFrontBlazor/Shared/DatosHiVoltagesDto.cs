using System;
using System.Collections.Generic;

namespace NetCoreAPIYFrontBlazor.Shared;

public class DatosHiVoltagesDto
{
    public DatosHiVoltagesDto()
    {
        hiVoltages = new List<HiVoltageDto>();
    }

    public List<HiVoltageDto> hiVoltages { get; set; }
}

public class HiVoltageDto
{
    public int id { get; set; }
    public int? transformadorId { get; set; }
    public string? wire { get; set; }
    public int? stripSizeMin { get; set; }
    public int? stripSizeMax { get; set; }
    public int? parallCondGrossWireMin { get; set; }
    public int? parallCondGrossWireMax { get; set; }
    public decimal? nudeCondGrossWire { get; set; }
    public decimal? nudeCond { get; set; }
    public int? parallCondMin { get; set; }
    public int? parallCondMax { get; set; }
}
