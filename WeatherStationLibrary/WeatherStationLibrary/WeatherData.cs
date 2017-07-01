using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationLibrary
{
    public class WeatherData
    {
        private double temperature;
        private double humidity;
        private double pressure;

        public double Humidity
        {
           get
            {
                return this.Humidity;
            }
            set
            {
                if (value > 100)
                {
                    this.humidity = 100;
                }
                else if (value < 0)
                {
                    this.humidity = 0;
                }
                else
                {
                    this.humidity = value;
                }
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                if (value > 1)
                    this.pressure = 1;
                else if (value < 0)
                    this.pressure = 0;
                else
                    this.pressure = value;
            }
        }

        public double Temperature
        {
            get
            {
                return this.Temperature;
            }
            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }

            }
        }

             

        public void SetTemperture(Double value)
        {
            if (value > 40)
            {
                this.temperature = 40;
            }
            else if (value < -10)
            {
                this.temperature = -10;
            }
            else
            {
                this.temperature = value;
            }

        }

        public double GetTemprature()
        {
            return this.temperature;
        }


        public bool Equals(WeatherData other)
        {
            return this.temperature == other.temperature
                   && this.Humidity == other.Humidity
                   && this.Pressure == other.Pressure;
        }
    }
}