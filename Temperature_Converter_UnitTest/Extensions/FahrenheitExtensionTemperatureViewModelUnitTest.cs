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
    public class FahrenheitExtensionTemperatureViewModelUnitTest
    {
        private Fahrenheit fahrenheit;

        [TestInitialize]
        public void TestInitialize()
        {
            fahrenheit = new Fahrenheit();
        }
        [TestMethod()]
        public void ConvertToCelsiusTest()
        {
            fahrenheit.Degrees = 95;

            double celsius = fahrenheit.ConvertToCelsius();

            Assert.AreEqual(35, celsius);
        }
        [TestMethod()]
        public void ConvertToCelsiusTest_Zero()
        {
            fahrenheit.Degrees = 0;

            double celsius = fahrenheit.ConvertToCelsius();

            Assert.AreEqual(-17.78, celsius);
        }
        [TestMethod()]
        public void ConvertToCelsiusTest_Negative()
        {
            fahrenheit.Degrees = -1;

            double celsius = fahrenheit.ConvertToCelsius();

            Assert.AreEqual(-18.33, celsius);
        }
    }
}