using Calculator.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator.Tests.Fixtures
{
    public class CalculatorFixture : IDisposable
    {
        public CalculatorFixture()
        {
            var collection = new ServiceCollection();
            collection.AddCalculator();
            ServiceProvider = collection.BuildServiceProvider();
        }

        public void Dispose()
        {
            ServiceProvider = null;
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
