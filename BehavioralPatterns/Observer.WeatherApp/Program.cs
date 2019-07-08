using System;
using Observer.WeatherApp.Observables;
using Observer.WeatherApp.Observers;

namespace Observer.WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherObservable weatherObservable = new WeatherObservable(0, 0, 0);
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherObservable, 0, 0);

            weatherObservable.SetTemperature(10);
            weatherObservable.SetHumidity(20);
            weatherObservable.SetPressure(20);

            weatherObservable.RemoveObserver(currentConditionsDisplay);

            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherObservable, 0);

            weatherObservable.SetMeasurements(100, 200, 200);

        }
    }
}
