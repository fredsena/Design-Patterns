using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Observer
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
