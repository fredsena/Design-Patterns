using System;
using System.Linq;
using Xunit;
using FluentAssertions;
using DesignPatterns.Core.Observer.WeatherDataObserver.Subject;
using DesignPatterns.Core.Observer.WeatherDataObserver.Observer;

namespace DesignPatterns.Tests
{
    public class WeatherDataObserverTests
    {
        [Fact]
        public void TestMethod1_WeatherStation()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            var result = currentDisplay.Display();

        }

        [Fact]
        public void Test_WeatherStationHeatIndex()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            var result = statisticsDisplay.Display();
        }
    }
}
