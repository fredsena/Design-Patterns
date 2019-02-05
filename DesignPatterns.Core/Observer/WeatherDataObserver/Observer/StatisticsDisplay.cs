using DesignPatterns.Core.Observer.WeatherDataObserver.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }

        public string Display()
        {
            return "Avg/Max/Min temperature = " + (tempSum / numReadings) + "/" + maxTemp + "/" + minTemp;
        }


    }
}
