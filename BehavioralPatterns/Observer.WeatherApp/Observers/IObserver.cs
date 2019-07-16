using Observer.WeatherApp.Observables;

namespace Observer.WeatherApp.Observers
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
