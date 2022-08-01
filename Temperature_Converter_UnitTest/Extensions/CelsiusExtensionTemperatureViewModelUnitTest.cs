using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converter.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Converter.Models;

namespace Temperature_Converter.Extensions.Temperature_Converter_UnitTest
{
    [TestClass()]
    public class CelsiusExtensionTemperatureViewModelUnitTest
    {
        private Celsius celsius;

        [TestInitialize]
        public void TestInitialize()
        {
            celsius = new Celsius();
        }
        [TestMethod()]
        public void ConvertToFahrenheitTest()
        {
            celsius.Degrees = 40;

            double fahrenheit = celsius.ConvertToFahrenheit();

            Assert.AreEqual(104, fahrenheit);
        }
        [TestMethod()]
        public void ConvertToFahrenheitTest_Zero()
        {
            celsius.Degrees = 0;

            double fahrenheit = celsius.ConvertToFahrenheit();

            Assert.AreEqual(32, fahrenheit);
        }
        [TestMethod()]
        public void ConvertToFahrenheitTest_Negative()
        {
            celsius.Degrees = -5;

            double fahrenheit = celsius.ConvertToFahrenheit();

            Assert.AreEqual(23, fahrenheit);
        }
    }
}