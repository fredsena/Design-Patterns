using DesignPatterns.Core.Observer.WeatherDataObserver.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public string Display()
        {
            return "Current conditions: " + _temperature +
                "F degrees and " + _humidity + "% humidity";
        }
    }
}
