using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Application.Queries.GetWeatherforecast
{
    public class GetWeatherforecastResponse
    {
        public IEnumerable<WeatherForecast>? Forecasts { get; init; }
    }

    public record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

}
