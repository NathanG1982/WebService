using Calculator.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Models;
using System;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        /// <summary>
        /// Calculate by operand
        /// </summary>
        /// <param name="request">Request data</param>
        /// <returns>Calculated result</returns>
        [HttpPost("calc")]
        public IActionResult Calc([FromBody] CalculatorOperandRequest request)
        {
            try
            {
                double result;
                switch (request.Operand)
                {
                    case "+":
                        {
                            result = _calculator.Sum(request.Numbers);
                            break;
                        }
                    case "-":
                        {
                            result = _calculator.Sub(request.Numbers);
                            break;
                        }
                    case "*":
                        {
                            result = _calculator.Mul(request.Numbers);
                            break;
                        }
                    case "/":
                        {
                            result = _calculator.Div(request.Numbers);
                            break;
                        }
                    default:
                        throw new Exception("Unknown operand");
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to calculate {operand} of numbers", request.Operand);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
