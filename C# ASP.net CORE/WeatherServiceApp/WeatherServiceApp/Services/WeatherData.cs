using System.Text.Json.Serialization;
using WeatherServiceApp.Services.Interfaces;

namespace WeatherServiceApp.Services;

public class WeatherData : IWeather
{
    public double Lat { get; set; }
    public double Long { get; set; }
    public string City { get; set; }

    public string Country { get; set; }
    public string Icon { get; set; }
    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public DateTime LastUpdated { get; set; }
}