
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
        public int ? Power { get; set; }
        public int ?Frecc { get; set; }
        public int? Cooling { get; set; }
        public int? HVTapNegNumero { get; set; }
        public int? HVTapNegRegulacion { get; set; }
        public int? HVTapNegMin { get; set; }
        public int? HVTapPosNumero { get; set; }
        public int? HVTapPosRegulacion { get; set; }
        public int? HVTapPosMin { get; set; }
        public int? OilKind { get; set; }


        public Transformador? Transformador { get; set; }

    }

}
