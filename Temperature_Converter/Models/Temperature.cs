using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperature_Converter.BusinessBase;

namespace Temperature_Converter.Models
{
    public abstract class Temperature : Model
    {
        private double degrees;

        public double Degrees
        {
            get => degrees;
            set
            {
                degrees = value;
                this.OnPropertyChanged(nameof(this.Degrees));
            }
        }

    }
}
