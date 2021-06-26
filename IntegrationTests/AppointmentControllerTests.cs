using Deus_Models.Models;
using deusbarbershop;
using deusbarbershop.Request;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class AppointmentControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client { get; set; }

        public AppointmentControllerTests(WebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }
   

        [Theory]
        [InlineData("/Service")]
        [InlineData("/Service/1")]
        public async Task Endpoint_Test_Should_ResultInOK(string endpoint)
        {
            var response = await _client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8",
            response.Content.Headers.ContentType.ToString());
            
        }
    }
}
