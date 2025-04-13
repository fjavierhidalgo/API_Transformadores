using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NetCoreAPIYFrontBlazor.Server.Domain;

namespace NetCoreAPIYFrontBlazor.Server.Application.Interfaces
{
	public interface IServerContext
	{
        DbSet<Hecho> Hechos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAndAuditAsync(string usuarioId, CancellationToken cancellationToken = default);

    }
}

