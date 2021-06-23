using AutoFixture;
using Calzolari.TestServer.EntityFramework.Database.EF;
using Deus_DataAccessLayer.Data;
using deusbarbershop;
using Xunit;

namespace FunctionalTests
{
    [Collection("AssemblyFixture")]
    public class DemoDb : IntegrationTestBase<ApplicationDbContext, Startup>
    {
        protected readonly IFixture Fixture;

        public DemoDb(TestFactory factory) : base(factory)
        {
            Fixture = new Fixture();
        }
    }
}
