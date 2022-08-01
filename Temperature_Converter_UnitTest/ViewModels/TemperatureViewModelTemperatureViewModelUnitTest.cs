using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converter.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter.ViewModels.Temperature_Converter_UnitTest
{
    [TestClass()]
    public class TemperatureViewModelTemperatureViewModelUnitTest
    {
        public TemperatureViewModel temperatureViewModel;
        [TestInitialize]
        public void TestInitialize()
        {
            temperatureViewModel = new TemperatureViewModel();
        }
        [TestMethod()]
        public void Can_Convert_From_Fahrenheit_To_Celsius()
        {
            //Arrange
            temperatureViewModel.Fahrenheit.Degrees = 95;
            temperatureViewModel.IsCelsiusChecked = false;
            //Act 
            temperatureViewModel.ConvertTemperature();
            //Assert
            Assert.AreEqual(35,temperatureViewModel.Celsius.Degrees);

        }
        [TestMethod()]
        public void Can_Convert_From_Celsius_To_Fahrenheit()
        {
            //Arrange
            temperatureViewModel.Celsius.Degrees = 40;
            temperatureViewModel.IsCelsiusChecked = true;
            //Act
            temperatureViewModel.ConvertTemperature();
            //Assert
            Assert.AreEqual(104,temperatureViewModel.Fahrenheit.Degrees);

        }
    }
}