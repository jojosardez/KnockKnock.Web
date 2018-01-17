using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockKnock.Web.Controllers
{
    [Route("api/Fibonacci")]
    public class FibonacciController : Controller
    {
        [HttpGet]
        public IActionResult Get(int? n)
        {
            if (n.HasValue)
            {
                int result = 0;
                
                if (Math.Abs(n.Value) != 0)
                {                    
                    var lastNumber = n > 0 ? 1 : -1;
                    var lastLastNumber = 0;

                    for (var index = 2; index <= Math.Abs(n.Value); index++)
                    {
                        result = lastNumber + lastLastNumber;
                        lastLastNumber = lastNumber;
                        lastNumber = result;
                    }
                    if (n.Value < 0 && Math.Abs(n.Value) % 2 != 0)
                        lastNumber = lastNumber * -1;
                    result = lastNumber;
                }

                return Ok(result);
            }
            return BadRequest("The request is invalid.");

        }
    }
}
