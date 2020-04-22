using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestableCodeDemo
{
    public class Calculator
    {
        public decimal GetTotal(decimal parts, decimal service, decimal discount)
        {
            return parts + service - discount;
        }

        public string ConfigTester(IConfiguration configuration)
        {
            return configuration["exclude"];
        }
    }
}
