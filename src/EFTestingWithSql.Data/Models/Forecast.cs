﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Data.Models
{
    public class Forecast
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Sumary { get; set; }
    }
}
