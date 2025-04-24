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
    internal class TransformadorConfiguration : IEntityTypeConfiguration<Transformador>
    {

        private const int NombreLength = 100;
        private const int ReferenciaLength = 40;
        public void Configure(EntityTypeBuilder<Transformador> builder)
        {
            builder.Property(n => n.Id).HasConversion<int>();            

            builder.Property(n => n.Nombre).HasMaxLength(NombreLength).IsFixedLength().HasColumnType($"varchar({NombreLength})");
            builder.Property(n => n.Referencia).HasMaxLength(ReferenciaLength).IsFixedLength().HasColumnType($"varchar({ReferenciaLength})");
            builder.Property(n => n.Detalle).HasColumnType($"varchar(max)");


        }
    }

}
