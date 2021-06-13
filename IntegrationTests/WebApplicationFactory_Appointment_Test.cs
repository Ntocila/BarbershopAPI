using Deus_Models.Models;
using deusbarbershop;
using deusbarbershop.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using WideWorldImporters.API.IntegrationTests;
using Xunit;

namespace IntegrationTests
{
    public class WebApplicationFactoryTest : IClassFixture<WebApplicationFactory<Startup>>
    {

        private const string Uri = "Appointment";
        private const string Uri_with_id = "Appointment/41";

        private static HttpClient _httpClientWithFullIntegration;

        private readonly WebApplicationFactory<Startup> _webApplicationFactory;

        public WebApplicationFactoryTest(WebApplicationFactory<Startup> webApplicationFactory)
        {
            _webApplicationFactory = webApplicationFactory;
            _httpClientWithFullIntegration ??= webApplicationFactory.CreateClient();
        }

        [Fact]
        public async void Get_Returns_AllAppointments()
        {

            //Act
            var appointmentResponse = await _httpClientWithFullIntegration.GetAsync(Uri);

            // Assert
            Assert.Equal(HttpStatusCode.OK, appointmentResponse.StatusCode);

        }


        [Fact]
        public async void Get_Returns_AppointmentById()
        {

            //Act
            var appointmentResponse = await _httpClientWithFullIntegration.GetAsync(Uri_with_id);


            //Assert
            Assert.Equal(HttpStatusCode.OK, appointmentResponse.StatusCode);

        }
    }
}
