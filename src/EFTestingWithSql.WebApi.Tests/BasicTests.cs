using Microsoft.AspNetCore.Mvc.Testing;
using System;

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
            var client = _factory.CreateClient();

            var client2 = _factory.CreateClient(null);

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299            
        }
    }
}