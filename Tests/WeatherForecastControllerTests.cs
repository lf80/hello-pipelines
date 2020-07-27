using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Linq;
using WebApi.Controllers;

namespace Tests
{
    public class WeatherForecastControllerTests
    {
        private Mock<ILogger<WeatherForecastController>> loggerStub = new Mock<ILogger<WeatherForecastController>>();

        [Test]
        public void ReturnsDefaultForecastDays()
        {
            var controller = new WeatherForecastController(loggerStub.Object);
            var expectedDays = 7;

            var forecast = controller.Get();

            Assert.NotNull(forecast);
            Assert.AreEqual(expectedDays, forecast.Count());
        }
    }
}