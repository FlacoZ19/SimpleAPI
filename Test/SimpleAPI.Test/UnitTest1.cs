using System;
using Xunit;
using SimpleAPI.Controllers;
using SimpleAPI.Test;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecast controller = new WeatherForecast();
        [Fact]
        public void GetReturnsData()
        {
            var returnValue = controller;
            Assert.Equal("Data",returnValue.Summary);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
