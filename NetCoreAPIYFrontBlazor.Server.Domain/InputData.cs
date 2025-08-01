
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


        public Transformador? Transformador { get; set; }

    }

}
