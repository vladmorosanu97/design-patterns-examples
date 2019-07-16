using System.Collections.Generic;
using Observer.WeatherApp.Observers;

namespace Observer.WeatherApp.Observables
{
    public class WeatherObservable : IObservable, IWeather
    {
        private readonly List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherObservable(float pressure, float humidity, float temperature)
        {
            _pressure = pressure;
            _humidity = humidity;
            _temperature = temperature;
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SetMeasurements(float pressure, float humidity, float temperature)
        {
            _humidity = humidity;
            _pressure = pressure;
            _temperature = temperature;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }

        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            MeasurementsChanged();
        }

        public void SetHumidity(float humidity)
        {
            _humidity = humidity;
            MeasurementsChanged();
        }

        public void SetPressure(float pressure)
        {
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}