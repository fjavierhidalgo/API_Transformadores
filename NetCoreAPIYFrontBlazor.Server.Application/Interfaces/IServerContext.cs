using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application.Interfaces
{
	public interface IServerContext
	{        
        DbSet<Transformador> Transformadores { get; set; }
        DbSet<InputData> InputsData { get; set; }
        DbSet<HiVoltage> HiVoltages { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAndAuditAsync(string usuarioId, CancellationToken cancellationToken = default);

    }
}

