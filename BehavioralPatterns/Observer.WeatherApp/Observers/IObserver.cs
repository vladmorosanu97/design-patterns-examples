using System;
using System.Collections.Generic;
using System.Text;
using Observer.WeatherApp.Models;
using Observer.WeatherApp.Observables;

namespace Observer.WeatherApp.Observers
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
