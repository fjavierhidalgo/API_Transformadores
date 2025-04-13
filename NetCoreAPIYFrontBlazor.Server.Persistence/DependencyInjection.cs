using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NetCoreAPIYFrontBlazor.Server.Application.Interfaces;

namespace NetCoreAPIYFrontBlazor.Server.Persistence
{
	public static class DependencyInjection
	{
        private static string database = "dbSqliteServer.db";

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ServerContext>(options =>
                options.UseSqlite(connectionString: "Filename=" + database,
                                 sqliteOptionsAction: op => { op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName); }));
            


            services.AddScoped<IServerContext>(provider => provider.GetService<ServerContext>());

            return services;
        }
    }
}

