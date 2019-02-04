using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Observer.WeatherDataObserver.Observer;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Subject
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature { get; set; }
        private float _humidity { get; set; }
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}
