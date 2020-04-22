using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestableCodeDemo
{
    //https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit
    [TestFixture]
    public class CalculatorTests
    {
        //SUT
        private Calculator _calculator;
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Method called immediately before each test is run
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
            var configurationBuilder = new ConfigurationBuilder()
        .AddJsonFile("appSettings.json");
       
            Configuration = configurationBuilder.Build();
        }

        [Test]
        public void TestGetTotalShouldReturnTotalPrice()
        {
            //Arrange Act
            var result = _calculator.GetTotal(1.00m, 2.00m, 0.50m);

            //Assert
            Assert.That(result, Is.EqualTo(2.50m));

            //Below will fail test case
            //Assert.That(result, Is.EqualTo(2.50m));
        }

        [Test]
        public void TestConfigMock()
        {
            var result = _calculator.ConfigTester(Configuration);


            Assert.That(result, Is.EqualTo("testValue"));

        }

    }
}
