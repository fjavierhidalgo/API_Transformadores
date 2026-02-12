using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Persistence.Configuration
{
    internal class HiVoltageConfiguration : IEntityTypeConfiguration<HiVoltage>
    {
        private const int WireLength = 100;

        public void Configure(EntityTypeBuilder<HiVoltage> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Id)
                .HasConversion<int>();

            builder.Property(h => h.Wire)
                .HasMaxLength(WireLength)
                .HasColumnType($"varchar({WireLength})");

            builder.Property(h => h.StripSizeMin)
                .HasColumnType("int");

            builder.Property(h => h.StripSizeMax)
                .HasColumnType("int");

            builder.Property(h => h.ParallCondGrossWireMin)
                .HasColumnType("int");

            builder.Property(h => h.ParallCondGrossWireMax)
                .HasColumnType("int");

            builder.Property(h => h.NudeCondGrossWire)
                .HasColumnType("decimal(18,6)");

            builder.Property(h => h.NudeCond)
                .HasColumnType("decimal(18,6)");

            builder.Property(h => h.ParallCondMin)
                .HasColumnType("int");

            builder.Property(h => h.ParallCondMax)
                .HasColumnType("int");

            // Configuración de la relación con Transformador
            builder.HasOne(h => h.Transformador)
                .WithMany()
                .HasForeignKey(h => h.TransformadorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
