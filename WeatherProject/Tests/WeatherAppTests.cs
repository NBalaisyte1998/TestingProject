using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using NUnit.Framework;
using WeatherProject.Weather_App_Service;

namespace WeatherProject.Tests
{
    [TestFixture()]
   public class WeatherAppTests
    {
        private WeatherAppService weatherAppService = new WeatherAppService();
        [Test()]
        public void WebCallSuccessCheck()
        {
            Assert.AreEqual(200, weatherAppService.weatherAppDTO.weatherAppRoot.cod);
        }


    }
}
