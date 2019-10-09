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
        [Test()]
        public void TemperaturePrincipalTest()
        {
            Assert.Greater(400, weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp);
        }
        // checking if its less than 500 Kelvins (impossibly high temperature)
        [Test()]
        public void MinimalTemperatureValue()
        {
            Assert.LessOrEqual(0, weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp_min);
            //lowest ever recorded temperature on earth
        }
        [Test()]
        public void MaximalTemperatureValue()
        {
            Assert.GreaterOrEqual(340, weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp_max);
        // highest temperature ever recorded on earth
         }
        [Test()]
        public void MinimalTemperaturenotNull()
        {
            Assert.IsNotNull(weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp);
        }
        [Test()]
        public void MaximalTemperatureIsnotNull()
        {
            Assert.IsNotNull(weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp_max);
        }
        [Test()]
        public void TemperaturePrincipalTestIsNotNuLL()
        {
            Assert.IsNotNull(weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.temp);
        }
        [Test()]
        public void PressurePrincipalTest()
        {
            Assert.LessOrEqual(400, weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.pressure);
        }
        [Test ()]
        public void PressureNotNull()
        {
            Assert.NotNull(weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.pressure);
        }
        [Test ()]
        public void SeaLevelPrincipialTest()
        {
            Assert.LessOrEqual(-400, weatherAppService.weatherAppDTO.weatherAppRoot.list[1].main.sea_level);
        }







    }
}
