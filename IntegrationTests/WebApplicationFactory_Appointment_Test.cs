using Deus_Models.Models;
using deusbarbershop;
using deusbarbershop.Controllers;
using deusbarbershop.Request;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class WebApplicationFactoryTest : IClassFixture<WebApplicationFactory<Startup>>
    {

        private const string Uri = "/Appointment";

        private static HttpClient _httpClientWithFullIntegration;

        private readonly WebApplicationFactory<Startup> _webApplicationFactory;

        public WebApplicationFactoryTest(WebApplicationFactory<Startup> webApplicationFactory)
        {
            _webApplicationFactory = webApplicationFactory;
            _httpClientWithFullIntegration ??= webApplicationFactory.CreateClient();
        }

        [Fact]
        public async Task Get_Returns_AllAppointments()
        {

            //Act
            var appointmentResponse = await _httpClientWithFullIntegration.GetAsync(Uri);

            appointmentResponse.EnsureSuccessStatusCode();

            var stringResponse = await appointmentResponse.Content.ReadAsStringAsync();
            var appointments = JsonConvert.DeserializeObject<List<Appointment>>(stringResponse);

            Assert.Contains(appointments, e => e.Customer.FirstName.Equals("string"));
            Assert.Contains(appointments, e => e.Customer.LastName.Equals("string"));
            Assert.Equal("application/json; charset=utf-8",
            appointmentResponse.Content.Headers.ContentType.ToString());
        }
    }
}
