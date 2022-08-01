using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Temperature_Converter.Extensions;
using Temperature_Converter.Models;

namespace Temperature_Converter.ViewModels
{
    public class TemperatureViewModel : ViewModel
    {
        public bool IsCelsiusChecked
        {
            get => _IsCelsiusChecked;
            set
            {
                _IsCelsiusChecked = value;
                if (_IsCelsiusChecked)
                {
                    if (this.Celsius.Degrees == 0) { ConvertTemperature(); }
                }
                OnPropertyChanged(nameof(IsCelsiusChecked));
            }
        }
        private bool _IsCelsiusChecked;
        public TemperatureViewModel()
        {
            this.Celsius = new Celsius();
            this.Fahrenheit = new Fahrenheit();
            this.IsCelsiusChecked = true;
            // this.CommandConvert = new RelayCommand(CommandConvertExecute, CanCommandConvertExecute);
            this.Celsius.PropertyChanged += Celsius_PropertyChanged;
            this.Fahrenheit.PropertyChanged += Fahrenheit_PropertyChanged;


        }

        private void Fahrenheit_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Degrees":
                    if (!IsCelsiusChecked)
                    {
                        Celsius.Degrees = this.Fahrenheit.ConvertToCelsius();
                    }
                    break;
            }
        }

        private void Celsius_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Degrees":
                    if (IsCelsiusChecked)
                    {
                        Fahrenheit.Degrees = this.Celsius.ConvertToFahrenheit();
                    }
                    break;
            }
        }

        public Celsius Celsius { get; set; }
        public Fahrenheit Fahrenheit { get; set; }

        public ICommand CommandConvert { set; get; }


        public void ConvertTemperature()
        {
            if (IsCelsiusChecked)
            {
                Fahrenheit.Degrees = this.Celsius.ConvertToFahrenheit();
            }
            else
            {
                Celsius.Degrees = this.Fahrenheit.ConvertToCelsius();

            }
        }
        private void CommandConvertExecute()
        {
            ConvertTemperature();
        }
        private bool CanCommandConvertExecute()
        {
            return true;
        }
        ~TemperatureViewModel()
        {
            Dispose();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Celsius.PropertyChanged -= Celsius_PropertyChanged;
                this.Fahrenheit.PropertyChanged -= Fahrenheit_PropertyChanged;
            }
        }


    }
}
