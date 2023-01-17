using EFTestingWithSql.Application.Queries.GetWeatherforecast;
using EFTestingWithSql.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.Json;

namespace EFTestingWithSql.WebApi.Tests
{
    public class BasicTests
        : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;

        public BasicTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/weatherforecast")]
        public async Task BasicTest(string url)
        {
            // Arrange
            using var db = _factory.CreateThrowawayDb();
            var client = _factory.CreateClientForDatabase(db);

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299            
            var result = await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>?>(response.Content.ReadAsStream());
            Assert.NotNull(result);
            Assert.Equal(30, result.Count());
        }

        [Fact]
        public async Task Given_No_Forecasts_Then_Should_Return_Empty_List()
        {
            // Arrange
            using var db = _factory.CreateThrowawayDb();

            using var scope = _factory.GetServiceProviderForDatabase(db).CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<WeatherContext>();
            var forcasts = await context.Forecasts.ToListAsync();
            context.Forecasts.RemoveRange(forcasts);
            await context.SaveChangesAsync();


            var client = _factory.CreateClientForDatabase(db);

            // Act
            var response = await client.GetAsync("/weatherforecast");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299            
            var result = await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>?>(response.Content.ReadAsStream());
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public async Task Given_No_Forecasts_Then_Should_Return_Empty_Lis2t()
        {
            // Arrange
            using var db = _factory.CreateThrowawayDb();
            using var dbContext = _factory.Services.GetRequiredService<WeatherContext>();
            dbContext.RemoveRange(dbContext.Forecasts);
            await dbContext.SaveChangesAsync();

            var client = _factory.CreateClientForDatabase(db);

            // Act
            var response = await client.GetAsync("/weatherforecast");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299            
            var result = await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>?>(response.Content.ReadAsStream());
            Assert.NotNull(result);
            Assert.Empty(result);

        }
    }
}