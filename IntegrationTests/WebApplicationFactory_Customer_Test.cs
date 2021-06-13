using deusbarbershop;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests
{
    public class WebApplicationFactory_Customer_Test : IClassFixture<WebApplicationFactory<Startup>>
    {
        private const string Uri = "Customer";
        private const string Uri_with_id = "Customer/27";

        private static HttpClient _httpClientWithFullIntegration;

        private readonly WebApplicationFactory<Startup> _webApplicationFactory;

        public WebApplicationFactory_Customer_Test( WebApplicationFactory<Startup> webApplicationFactory)
        {
            _webApplicationFactory = webApplicationFactory;
            _httpClientWithFullIntegration ??= webApplicationFactory.CreateClient();
        }


        [Fact]
        public async void Get_Returns_AllCustomers()
        {

            //Act
            var customerResponse = await _httpClientWithFullIntegration.GetAsync(Uri);

            // Assert
            Assert.Equal(HttpStatusCode.OK, customerResponse.StatusCode);

        }


        [Fact]
        public async void Get_Returns_CustomerById()
        {

            //Act
            var customerResponse = await _httpClientWithFullIntegration.GetAsync(Uri_with_id);


            //Assert
            Assert.Equal(HttpStatusCode.OK, customerResponse.StatusCode);

        }
    }
}
