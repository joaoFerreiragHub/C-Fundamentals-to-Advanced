namespace WeatherServiceApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IWeatherService _weatherService;

    public IndexModel(ILogger<IndexModel> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    public IWeather Data { get; set; }

    [BindProperty]
    public string City { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        Data = _weatherService.GetWeather(City);
    }
}