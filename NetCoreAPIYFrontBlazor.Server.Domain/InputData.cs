
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIYFrontBlazor.Server.Domain
{
    
    public class InputData
    {
        public int Id { get; set; }
        public int? TransformadorId { get; set; }
        public string? Project { get; set; }
        public string? Customer { get; set; }       
        public int ? Power { get; set; }
        public int ?Frecc { get; set; }
        public string? Cooling { get; set; }
        public decimal? HVTapNegNumero { get; set; }
        public decimal? HVTapNegRegulacion { get; set; }
        public decimal? HVTapNegMin { get; set; }
        public decimal? HVTapPosNumero { get; set; }
        public decimal? HVTapPosRegulacion { get; set; }
        public decimal? HVTapPosMax { get; set; }
        public string? OilKind { get; set; }

        public string? Standard { get; set; }
        public DateTime? Date { get; set; }
        public string? Rev { get; set; }
        public string? Type { get; set; }
        public string? OFNum { get; set; }
        public string? Designer { get; set; }
        public int? LineVoltHV1 { get; set; }
        public int? LineVoltGuion { get; set; }
        public int? LineVoltLV1 { get; set; }
        public int? LineVoltVacio { get; set; }
        public int? LineVoltVacio2 { get; set; }
        public string? ConectionHV1 { get; set; }
        public string? ConectionLV1 { get; set; }
        public string? ConectionVacio2 { get; set; }
        public int? TurnsLV1 { get; set; }
        public int? Foils { get; set; }
        public decimal? Altitude { get; set; }
        public decimal? TMax { get; set; }
        public string? HVBIL { get; set; }
        public string? LVBIL { get; set; }
        public string? HVKIND { get; set; }
        public string? LVKIND { get; set; }
        public string? NLLosses { get; set; }
        public string? Llosses { get; set; }
        public string? HVMAT { get; set; }
        public string? LVMAT { get; set; }
        public int? Noise { get; set; }
        public int? SC { get; set; }
        public string? NoiseKP { get; set; }
        public string? NoiseKHi { get; set; }
        public string? NoiseKSB { get; set; }
        public string? NoiseKV { get; set; }
        public int? KRBT { get; set; }
        public int? KRAB { get; set; }
        

        public Transformador? Transformador { get; set; }

    }

}
