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
builder.Services.AddDbContext<WeatherContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddMediatR(typeof(ApplicationReference));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/weatherforecast", async (IMediator mediator, ILogger<Program> logger) =>
{
	try
	{
        var result = await mediator.Send(new GetWeatherforecastRequest());
        return result.Forecasts;
    }
	catch (Exception ex)
	{
        logger.LogError(ex, "Failed to fetch forcasts.");
		throw;
	}
    
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

public partial class Program { } // Makes this class public for the console app template.