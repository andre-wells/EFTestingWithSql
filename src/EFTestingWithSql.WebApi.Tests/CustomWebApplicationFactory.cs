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

namespace EFTestingWithSql.WebApi.Tests
{
    public class DatabaseConnectionSettings
    {
        public string ConnectionString { get; set; } = "";
    }

    public class CustomWebApplicationFactory<TProgram> 
        : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {            
        }

        public HttpClient CreateClient(ThrowawayDatabase? db)
        {
            return this.WithWebHostBuilder(config =>
            {
                config.ConfigureTestServices(services =>
                {
                    
                });                

            }).CreateClient();
        }
    }
}
