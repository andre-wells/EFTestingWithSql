using EFTestingWithSql.Data;
using EFTestingWithSql.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Application.Queries.GetWeatherforecast
{
    internal class GetWeatherforecast : IRequestHandler<GetWeatherforecastRequest, GetWeatherforecastResponse>
    {
        private readonly WeatherContext _context;

        public GetWeatherforecast(WeatherContext context)
        {
            _context = context;
        }               

        public async Task<GetWeatherforecastResponse> Handle(GetWeatherforecastRequest request, CancellationToken cancellationToken)
        {
            return new GetWeatherforecastResponse { 
                Forecasts = await _context.Forecasts
                .Select(x => new WeatherForecast(DateOnly.FromDateTime(x.Date), x.TemperatureC, x.Sumary))
                .ToListAsync()
            };
            
        }
    }
}
