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
        [Test()]
        public void RightMessage()
        {
            Assert.Greater(0.1, weatherAppService.weatherAppDTO.weatherAppRoot.message);
        }
        [Test()]
        public void CNTTest()
        {
            Assert.AreEqual(40, weatherAppService.weatherAppDTO.weatherAppRoot.cnt);
        }
        [Test()]
        public void dtTestCharacterLenght()
        {
            string dtlenght = weatherAppService.weatherAppDTO.weatherAppRoot.list[0].dt.ToString();
            Assert.AreEqual(10, dtlenght.Length);
        }



    }
}
