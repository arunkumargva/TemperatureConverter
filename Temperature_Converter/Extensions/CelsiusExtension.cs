using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Converter.Models;

namespace Temperature_Converter.Extensions
{
    public static class CelsiusExtension
    {
        public static double ConvertToFahrenheit(this Celsius celsius)
        {
            return Math.Round((celsius.Degrees * 9) / 5 + 32, 2);

        }
    }
}
