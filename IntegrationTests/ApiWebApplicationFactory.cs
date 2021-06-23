using Deus_DataAccessLayer.Data;
using Deus_DataAccessLayer.IRepositories;
using Deus_DataAccessLayer.Services;
using deusbarbershop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace IntegrationTests
{
    public class ApiWebApplicationFactory: WebApplicationFactory<deusbarbershop.Startup>
    {
        public IConfiguration Configuration { get; private set; }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                config.AddConfiguration(Configuration);
            });
            builder.ConfigureServices(services =>
            {
                services.AddTransient<IAppointmentRepository, AppointmentRepository>();

                services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseNpgsql("DefaultConnection");
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<ApplicationDbContext>();
                    var logger = scopedServices
                        .GetRequiredService<ILogger<WebApplicationFactory<Startup>>>();

                    db.Database.EnsureCreated();
                };
            });
        }
    }
}
