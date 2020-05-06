using InfiniteLambda.PrimeNumber.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InfiniteLambda.PrimeNumber.Api.Controllers
{
    [Route("api/prime-number")]
    [ApiController]
    public class PrimeNumberController : ControllerBase
    {
        private readonly IPrimeNumberService primeNumberService;

        public PrimeNumberController(IPrimeNumberService primeNumberService)
        {
            this.primeNumberService = primeNumberService;
        }

        [HttpGet("is-prime/{number:int}")]
        public IActionResult IsPrimeNumber([FromRoute] int number)
        {
            var result = primeNumberService.CheckWhetherPrimeNumber(number);

            return Ok(result);
        }

        [HttpGet("next-prime-number/{number:int}")]
        public IActionResult GetNextPrimeNumber([FromRoute] int number)
        {
            var nextPrimeNumber = primeNumberService.GetNextPrimeNumber(number);

            return Ok(nextPrimeNumber);
        }
    }
}
