using System;
using System.Collections.Generic;
using System.Text;
using Observer.WeatherApp.Observables;

namespace Observer.WeatherApp.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private readonly IObservable _observable;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(IObservable observable, float humidity, float temperature)
        {
            _observable = observable;
            _humidity = humidity;
            _temperature = temperature;
            _observable.RegisterObserver(this);
        }

        public void Update(IObservable observable)
        {
            if (observable is WeatherObservable weatherObservable)
            {
                _temperature = weatherObservable.GetTemperature();
                _humidity = weatherObservable.GetHumidity();
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + " F degrees and " + _humidity + " humidity");
        }
    }
}