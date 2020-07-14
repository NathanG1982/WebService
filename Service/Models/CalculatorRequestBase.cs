using System.Collections.Generic;

namespace Service.Models
{
    public class CalculatorRequestBase
    {
        public IEnumerable<double> Numbers { get; set; }
    }
}