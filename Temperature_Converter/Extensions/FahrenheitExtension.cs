using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Converter.Models;

namespace Temperature_Converter.Extensions
{
    public static class FahrenheitExtension
    {
        public static double ConvertToCelsius(this Fahrenheit fahrenheit)
        {
            return Math.Round((fahrenheit.Degrees - 32) * 5 / 9, 2);

        }
    }
}
