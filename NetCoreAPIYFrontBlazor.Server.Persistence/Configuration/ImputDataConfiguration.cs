using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Configuration
{
    internal class InputDataConfiguration : IEntityTypeConfiguration<InputData>
    {

       
        public void Configure(EntityTypeBuilder<InputData> builder)
        {
            builder.Property(n => n.Id).HasConversion<int>();            

            builder.Property(n => n.Project).HasColumnType($"varchar(30)");
            builder.Property(n => n.Customer).HasColumnType($"varchar(30)");
            builder.Property(n => n.Cooling).HasColumnType($"varchar(10)");
            builder.Property(n => n.OilKind).HasColumnType($"varchar(20)");

            builder.Property(n => n.Standard).HasColumnType($"varchar(20)");
            builder.Property(n => n.Rev).HasColumnType($"varchar(20)");
            builder.Property(n => n.Type).HasColumnType($"varchar(20)");
            builder.Property(n => n.OFNum).HasColumnType($"varchar(20)");
            builder.Property(n => n.Designer).HasColumnType($"varchar(20)");
            builder.Property(n => n.ConectionHV1).HasColumnType($"varchar(20)");
            builder.Property(n => n.ConectionLV1).HasColumnType($"varchar(20)");
            builder.Property(n => n.ConectionVacio2).HasColumnType($"varchar(20)");
            builder.Property(n => n.HVBIL).HasColumnType($"varchar(20)");
            builder.Property(n => n.LVBIL).HasColumnType($"varchar(20)");
            builder.Property(n => n.HVKIND).HasColumnType($"varchar(20)");
            builder.Property(n => n.LVKIND).HasColumnType($"varchar(20)");
            builder.Property(n => n.NLLosses).HasColumnType($"varchar(20)");
            builder.Property(n => n.Llosses).HasColumnType($"varchar(20)");
            builder.Property(n => n.HVMAT).HasColumnType($"varchar(20)");
            builder.Property(n => n.LVMAT).HasColumnType($"varchar(20)");
            builder.Property(n => n.NoiseKP).HasColumnType($"varchar(1)");
            builder.Property(n => n.NoiseKHi).HasColumnType($"varchar(1)");
            builder.Property(n => n.NoiseKSB).HasColumnType($"varchar(1)");
            builder.Property(n => n.NoiseKV).HasColumnType($"varchar(1)");

            /*
                        public string? Standard { get; set; }

                    public string? Rev { get; set; }
                    public string? Type { get; set; }
                    public string? OFNum { get; set; }
                    public string? Designer { get; set; }

                    public string? ConectionHV1 { get; set; }
                    public string? ConectionLV1 { get; set; }
                    public string? ConectionVacio2 { get; set; }

                     public string? HVBIL { get; set; }
        public string? LVBIL { get; set; }
        public string? HVKIND { get; set; }
        public string? LVKIND { get; set; }
        public string? NLLosses { get; set; }
        public string? Llosses { get; set; }
        public string? HVMAT { get; set; }
        public string? LVMAT { get; set; }
        public string? NoiseKP { get; set; }
        public string? NoiseKHi { get; set; }
        public string? NoiseKSB { get; set; }
        public string? NoiseKV { get; set; }





            */
        }
    }

}
