using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAPIYFrontBlazor.Server.Domain
{
    public class HiVoltage
    {
        public int Id { get; set; }
        public int? TransformadorId { get; set; }

        public string? Wire { get; set; }
        public int? StripSizeMin { get; set; }
        public int? StripSizeMax { get; set; }
        public int? ParallCondGrossWireMin { get; set; }
        public int? ParallCondGrossWireMax { get; set; }
        public decimal? NudeCondGrossWire { get; set; }
        public decimal? NudeCond { get; set; }
        public int? ParallCondMin { get; set; }
        public int? ParallCondMax { get; set; }

        public Transformador? Transformador { get; set; }
    }
}
