using System;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace NetCoreAPIYFrontBlazor.Server.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;
        }
    }
}

