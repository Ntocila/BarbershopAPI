using Deus_DataAccessLayer.Data;
using Deus_DataAccessLayer.IRepositories;
using Deus_DataAccessLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Deus_DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<ApplicationDbContext>(
                dbContextoptions => dbContextoptions
                                    .UseMySql(connectionString, new MariaDbServerVersion(new Version(10, 5, 9)))
                                    .EnableSensitiveDataLogging()
                                    .EnableDetailedErrors()
                );


            services.AddTransient<IServiceRepository, ServiceRepository>();

            return services;
        }
    }

}
