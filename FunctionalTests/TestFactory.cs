using Calzolari.TestServer.EntityFramework.Flurl;
using deusbarbershop;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FunctionalTests
{
    public class TestFactory : FlurlWebFactory<Startup>
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureWebHost((builder) =>
            {
                builder.UseStartup<TestStartup>();
            });
        }
    }
}