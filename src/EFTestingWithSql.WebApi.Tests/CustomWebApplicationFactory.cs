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

        public HttpClient CreateClientWithDatabase(ThrowawayDatabase db)
        {
            return this.WithWebHostBuilder(config =>
            {
                // Perofrm any 
                config.ConfigureTestServices(services =>
                {
                    var dbContextDescriptor = services.SingleOrDefault(d => d.ServiceType ==typeof(DbContextOptions<WeatherContext>));

                    ArgumentNullException.ThrowIfNull(dbContextDescriptor);

                     services.Remove(dbContextDescriptor);

                    services.AddDbContext<WeatherContext>(opt => opt.UseSqlServer(db.ConnectionString));

                });

            }).CreateClient();
        }

        internal ThrowawayDatabase CreateThrowawayDb()
        {
            // Instance could be configured through environment variables.           
            // If feasible, we could create the database in this step instead of relying on the WebApi to run migrations.
            return ThrowawayDatabase.FromLocalInstance("(localdb)\\mssqllocaldb", "TEST_"); 
            
        }
    }
}
