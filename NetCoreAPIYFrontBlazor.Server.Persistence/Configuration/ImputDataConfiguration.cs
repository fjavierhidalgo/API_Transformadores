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

 
        }
    }

}
