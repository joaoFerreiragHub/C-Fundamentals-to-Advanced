using System.Text.Json.Serialization;
using RestSharp;
using WeatherServiceApp.Services.Interfaces;

namespace WeatherServiceApp.Services;

public class WeatherStackService : IWeatherService
{
    // Note: 
    string _key = "38b3bd4c15a2eeede38dec1ef51bdd86";
    string _baseUrl = "http://api.weatherstack.com/current?access_key={0}&query={1}";

    // RestSharp

    public IWeather GetWeather(string city)
    {
        var url =  string.Format(_baseUrl, _key, city );

        var client = new RestClient(url);
        var request = new RestRequest("", Method.Get);

        var result = client.ExecuteAsync<Root>(request).Result;

        var data = result.Data;

        var weatherData = new WeatherData
        {
            City = data.location.name,
            Country = data.location.country,
            Icon = data.current.weather_icons.First(),
            LastUpdated = DateTime.Parse(data.location.localtime),
            Lat = double.Parse(data.location.lat.Replace(".", ",")),
            Long = double.Parse(data.location.lon.Replace(".", ",")),
            Temperature = data.current.temperature,
            Humidity = data.current.humidity
        };

        return weatherData;
    }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class Root
{
    public Request request { get; set; }
    public Location location { get; set; }
    public Current current { get; set; }
}

public class Request
{
    public string type { get; set; }
    public string query { get; set; }
    public string language { get; set; }
    public string unit { get; set; }
}

public class Location
{
    public string name { get; set; }
    public string country { get; set; }
    public string region { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
    public string timezone_id { get; set; }
    public string localtime { get; set; }
    public int localtime_epoch { get; set; }

    [JsonPropertyName("utc_offset")]
    public string UtcOffset { get; set; }
}

public class Current
{
    public string observation_time { get; set; }
    public int temperature { get; set; }
    public int weather_code { get; set; }
    public List<string> weather_icons { get; set; }
    public List<string> weather_descriptions { get; set; }
    public int wind_speed { get; set; }
    public int wind_degree { get; set; }
    public string wind_dir { get; set; }
    public int pressure { get; set; }
    public double precip { get; set; }
    public int humidity { get; set; }
    public int cloudcover { get; set; }
    public int feelslike { get; set; }
    public int uv_index { get; set; }
    public int visibility { get; set; }
    public string is_day { get; set; }
}



