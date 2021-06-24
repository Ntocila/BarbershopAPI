using Deus_DataAccessLayer.IRepositories;
using Deus_DataAccessLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_DataAccessLayer.Data
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                 options.UseNpgsql(connectionString);
        });

            services.AddTransient<IAppointmentRepository, AppointmentRepository>();

            return services;
        }
    }
}
