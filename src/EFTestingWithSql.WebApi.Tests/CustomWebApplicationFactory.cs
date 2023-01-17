using EFTestingWithSql.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThrowawayDb;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json.Bson;
using System.Reflection.Metadata.Ecma335;

namespace EFTestingWithSql.WebApi.Tests
{
    public class CustomWebApplicationFactory<TProgram>
        : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // Perform any configuration here that applies to all tests
            // such as replacing an external data store with a fake.
        }

        internal HttpClient CreateClientForDatabase(ThrowawayDatabase db) 
            => GetFactoryForDatabase(db).CreateClient();


        internal IServiceProvider GetServiceProviderForDatabase(ThrowawayDatabase db)
            => GetFactoryForDatabase(db).Services;

        internal ThrowawayDatabase CreateThrowawayDb()
        {
            // Instance could be configured through environment variables.                       

            var db = ThrowawayDatabase.FromLocalInstance("(localdb)\\mssqllocaldb", "TEST_");

            var factory = GetFactoryForDatabase(db);

            // Apply migrations
            using var scope = factory.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<WeatherContext>();
            context.Database.Migrate();

            return db;

        }

        private WebApplicationFactory<TProgram> GetFactoryForDatabase(ThrowawayDatabase db) =>
            WithWebHostBuilder(config =>
            {                
                config.ConfigureTestServices(services =>
                {
                    var dbContextDescriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<WeatherContext>));

                    ArgumentNullException.ThrowIfNull(dbContextDescriptor);

                    services.Remove(dbContextDescriptor);

                    services.AddDbContext<WeatherContext>(opt => opt.UseSqlServer(db.ConnectionString));

                });

            });
    }
}
