﻿namespace Observer.WeatherApp.Observables
{
    public interface IWeather
    {
        float GetTemperature();
        float GetHumidity();
        float GetPressure();
        void SetTemperature(float temperature);
        void SetHumidity(float humidity);
        void SetPressure(float pressure);
    }
}
