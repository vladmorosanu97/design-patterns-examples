using System;
using Observer.WeatherApp.Observables;

namespace Observer.WeatherApp.Observers
{
    public class StatisticsDisplay: IObserver, IDisplay
    {
        private readonly IObservable _observable;
        private float _pressure;
        public StatisticsDisplay(IObservable observable, float pressure)
        {
            _observable = observable;
            this._pressure = pressure;
            _observable.RegisterObserver(this);
        }

        public void Update(IObservable observable)
        {
            if (observable is WeatherObservable weatherObservable)
            {
                _pressure = weatherObservable.GetPressure();
                Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Pressure is " + _pressure);
        }
    }
}
