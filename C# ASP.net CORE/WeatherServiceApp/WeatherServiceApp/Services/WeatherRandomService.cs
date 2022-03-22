using WeatherServiceApp.ExtensionMethods;

namespace WeatherServiceApp.Services;

public class WeatherRandomService : IWeatherService
{
    public IWeather GetWeather(string city)
    {
        return new WeatherData()
        {
            City = "Leiria",
            Country = "Portugal",
            LastUpdated = DateTime.Now,
            Temperature = 8
        };
    }
}