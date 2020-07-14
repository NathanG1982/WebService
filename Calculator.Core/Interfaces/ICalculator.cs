using System;
using System.Collections.Generic;

namespace Calculator.Core
{
    public interface ICalculator
    {
        /// <summary>
        /// Calculate sum of numbers
        /// </summary>
        /// <param name="numbers">Numbers for calculation</param>
        /// <returns>Calculated result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="numbers"/> is null</exception>
        double Sum(IEnumerable<double> numbers);

        /// <summary>
        /// Calculate sub of numbers
        /// </summary>
        /// <param name="numbers">Numbers for calculation</param>
        /// <returns>Calculated result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="numbers"/> is null</exception>
        double Sub(IEnumerable<double> numbers);

        /// <summary>
        /// Calculate mul of numbers
        /// </summary>
        /// <param name="numbers">Numbers for calculation</param>
        /// <returns>Calculated result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="numbers"/> is null</exception>
        double Mul(IEnumerable<double> numbers);

        /// <summary>
        /// Calculate div of numbers
        /// </summary>
        /// <param name="numbers">Numbers for calculation</param>
        /// <returns>Calculated result</returns>
        /// <exception cref="ArgumentNullException"><paramref name="numbers"/> is null</exception>
        double Div(IEnumerable<double> numbers);
    }
}