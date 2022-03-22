namespace WeatherServiceApp.Services.Interfaces
{
    public interface IWeatherService
    {
        IWeather GetWeather(string city);
    }
}
