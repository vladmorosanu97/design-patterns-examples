using System;
using System.Collections.Generic;
using System.Text;
using Observer.WeatherApp.Observers;

namespace Observer.WeatherApp.Observables
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}