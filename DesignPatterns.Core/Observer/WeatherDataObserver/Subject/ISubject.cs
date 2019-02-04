using DesignPatterns.Core.Observer.WeatherDataObserver.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Observer.WeatherDataObserver.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
