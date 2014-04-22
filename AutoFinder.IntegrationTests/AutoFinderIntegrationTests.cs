using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoFinder.Api;
using Microsoft.Owin.Hosting;
using NUnit.Framework;

namespace AutoFinder.InProcessHost
{
    [TestFixture]
    public class AutoFinderIntegrationTests
    {
        [Test]
        public async void GetSomeCars()
        {
            var baseAddress = "http://localhost:9000/";
            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();
                var response = client.GetAsync(baseAddress + "api/car/1").Result;
                var car = await response.Content.ReadAsAsync<Car>();

                Assert.That(car.Id, Is.EqualTo(1));
                Assert.That(car.Color, Is.EqualTo("red"));
            }

        }
    }
}
