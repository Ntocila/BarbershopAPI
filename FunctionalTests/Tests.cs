using Deus_Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using Flurl.Http;
using Xunit;
using Calzolari.TestServer.EntityFramework.Flurl;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

namespace FunctionalTests
{
    [JsonArray]
    public class Tests : DemoDb
    {
        private const string BaseRoute = "/Appointment";

        public Tests(TestFactory factory) : base(factory)
        {

        }

        [Fact]
        public async Task When_Route_Is_Correct_and_Db_Fed_Should_Return_OK()
        {
            var appointments = Fixture.Create<Appointment>();

            Arrange(dbcontext => dbcontext.Appointments.Add(appointments));

            var response = await BASE_REQUEST.Route(BaseRoute).GetAsync();
  
            response.ResponseMessage.Should().Be200Ok().And.BeAs(appointments);
        }
    }
}
