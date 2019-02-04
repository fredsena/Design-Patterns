using DesignPatterns.Core.Observer.WeatherDataObserver.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public string Display()
        {
            string result;

            result = "Forecast: ";
            if (_currentPressure > _lastPressure)
            {
                result += "Improving weather on the way!";
            }
            else if (_currentPressure == _lastPressure)
            {
                result += "More of the same";
            }
            else if (_currentPressure < _lastPressure)
            {
                result += "Watch out for cooler, rainy weather";
            }

            return result;
        }
    }
}
