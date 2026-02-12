using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;
using NetCoreAPIYFrontBlazor.Server.Domain;


namespace NetCoreAPIYFrontBlazor.Server.Persistence;
public class ServerContext : DbContext, IServerContext
{

    public ServerContext(DbContextOptions<ServerContext> options)
    : base(options)
    {
    }
   

    private string database = "dbSqliteServer.db";

   

    public DbSet<Auditoria> Auditoria { get; set; }
    public DbSet<Transformador> Transformadores { get; set; }
    public DbSet<InputData> InputsData { get; set; }
    public DbSet<HiVoltage> HiVoltages { get; set; }


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{

    //    optionsBuilder.UseSqlite(connectionString: "Filename=" + database,
    //                             sqliteOptionsAction: op =>
    //                             {
    //                                 op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
    //                             }
    //        );

    //    base.OnConfiguring(optionsBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ServerContext).Assembly);

        //modelBuilder.Entity<Hecho>().ToTable("Hechos");
        //modelBuilder.Entity<Hecho>(entidad =>
        //{
        //    entidad.HasKey(k => k.Id);
        //});
       
        base.OnModelCreating(modelBuilder);
    }


    public Task<int> SaveChangesAndAuditAsync(string usuarioId, CancellationToken cancellationToken = default)
    {
        ChangeTracker.DetectChanges();
        DateTime fechaModificaciones = DateTime.Now;

        foreach (EntityEntry entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Modified))
        {
            foreach (IProperty prop in entry.OriginalValues.Properties)
            {
                string entidad = entry.Metadata.GetTableName();
                string entidadId = entry.OriginalValues["Id"]?.ToString()?.Trim();
                string originalValue = entry.OriginalValues[prop]?.ToString()?.Trim();
                string currentValue = entry.CurrentValues[prop]?.ToString()?.Trim();

                if (originalValue != currentValue)
                {
                    Auditoria.Add(new Auditoria(entidad, entidadId, prop.Name, originalValue, currentValue, usuarioId));
                }
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

   

}

