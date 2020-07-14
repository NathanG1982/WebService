using Calculator.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Core.Services
{
    /// <summary>
    /// Simple calculator class.
    /// Will perform basic calculations
    /// </summary>
    class SimpleCalculator : CalculatorBase, ICalculator
    {
        public double Sum(IEnumerable<double> numbers)
            => numbers?.Sum() ?? throw new ArgumentNullException(nameof(numbers));

        public double Sub(IEnumerable<double> numbers)
            => numbers?.Count() > 1 
            ? numbers.Skip(1).Aggregate(numbers.FirstOrDefault(), (current, number) => current - number) 
            : throw new ArgumentNullException(nameof(numbers));

        public double Mul(IEnumerable<double> numbers)
            => numbers?.Count() > 1
                ? numbers.Skip(1).Aggregate(numbers.FirstOrDefault(), (current, number) => current * number)
                : throw new ArgumentNullException(nameof(numbers));

        public double Div(IEnumerable<double> numbers)
            => numbers == null 
                ? throw new ArgumentNullException(nameof(numbers))
                : numbers.Count() < 2
                    ? throw new ArgumentException("at least two numbers")
                    : numbers.Skip(1).Any(v => v == 0d)
                        ? throw new ArgumentException("divide by zero not allowed")
                        : numbers.FirstOrDefault() == 0
                            ? 0
                            : numbers.Skip(1).Aggregate(numbers.FirstOrDefault(), (current, number) => current / number);
    }
}
