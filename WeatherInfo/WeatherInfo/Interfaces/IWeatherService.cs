using WeatherInfo.Models;

namespace WeatherInfo.Interfaces;

public interface IWeatherForecastService
{
    public IEnumerable<WeatherForecast> Get();
}
