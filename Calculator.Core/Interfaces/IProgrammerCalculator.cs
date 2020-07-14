namespace Calculator.Core
{
    public interface IProgrammerCalculator : ICalculator
    {
        /// <summary>
        /// Calculate sum of numbers
        /// </summary>
        /// <param name="number">Number for calculation</param>
        /// <returns>Calculated result</returns>
        double ConvertToBinary(double number);
    }
}
