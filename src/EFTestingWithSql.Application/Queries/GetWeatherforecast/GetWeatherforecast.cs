using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Application.Queries.GetWeatherforecast
{



    internal class GetWeatherforecast : IRequestHandler<GetWeatherforecastRequest, GetWeatherforecastResponse>
    {

        private string[] summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<GetWeatherforecastResponse> Handle(GetWeatherforecastRequest request, CancellationToken cancellationToken)
        {
            var forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ));
            return Task.FromResult(new GetWeatherforecastResponse { Forecasts = forecast });
        }
    }
}
