using Microsoft.AspNetCore.Mvc;
using WeatherInfo.Interfaces;
using WeatherInfo.Models;

namespace WeatherInfo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _weatherForecastService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherForecastService weatherService, ILogger<WeatherForecastController> logger)
    {
        _weatherForecastService = weatherService;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherForecastService.Get();
    }
}
