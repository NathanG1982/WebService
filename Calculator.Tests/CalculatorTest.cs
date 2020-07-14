using Calculator.Core;
using Calculator.Tests.Fixtures;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly CalculatorFixture _fixture;

        public CalculatorTest(CalculatorFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Calculator_Sum()
        {
            var calculator = _fixture.ServiceProvider.GetService<ICalculator>();
            var result = calculator.Sum(new double[] {1, 2, 4});
            Assert.Equal(7, result);
        }
    }
}
