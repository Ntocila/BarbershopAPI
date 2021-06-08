using deusbarbershop;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API_Tests
{
  public   class WebApplicationFactory
    {
        public readonly HttpClient _httpClient;
        public WebApplicationFactory()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _httpClient = appFactory.CreateClient();
        }

    }
}
