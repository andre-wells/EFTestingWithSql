using EFTestingWithSql.Application.Queries.GetWeatherforecast;
using EFTestingWithSql.Application;
using MediatR;
using Microsoft.EntityFrameworkCore;
using EFTestingWithSql.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<WeatherContext>(opt => opt.UseInMemoryDatabase("Weather"));
builder.Services.AddMediatR(typeof(ApplicationReference));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/weatherforecast", async (IMediator mediator) =>
{
    var result = await mediator.Send(new GetWeatherforecastRequest());
    return result.Forecasts;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();
