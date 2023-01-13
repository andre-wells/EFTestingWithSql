using EFTestingWithSql.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Data
{
    public class WeatherContext : DbContext
    {

        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options)
        {

        }

        public DbSet<Forecast> Forecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string[] summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var rand = new Random(4337);

            var seedData = Enumerable.Range(0, 30).Select(index =>
            
                new Forecast { Id = index + 1, Date = DateTime.Now.Date.AddDays(index * -1), TemperatureC = rand.Next(0,30), Sumary = summaries[rand.Next(0, summaries.Length)] }
            );

            modelBuilder.Entity<Forecast>().HasData(seedData);
        }

    }
}
