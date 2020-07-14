using Calculator.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammerCalculatorController : ControllerBase
    {
        private readonly IProgrammerCalculator _calculator;
        private readonly ILogger<ProgrammerCalculatorController> _logger;

        public ProgrammerCalculatorController(ILogger<ProgrammerCalculatorController> logger, IProgrammerCalculator calculator)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
        }

        /// <summary>
        /// Not implemented.
        /// Just for demo purposes.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpPost("binary/{number:double}")]
        public IActionResult Calculate([FromRoute] double number)
        {
            try
            {
                var result = _calculator.ConvertToBinary(number);
                return Ok(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}