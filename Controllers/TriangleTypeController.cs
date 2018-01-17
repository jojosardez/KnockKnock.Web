using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockKnock.Web.Controllers
{
    [Route("api/TriangleType")]
    public class TriangleTypeController : Controller
    {
        [HttpGet]
        public IActionResult Get(int? a, int? b, int? c)
        {
            if (a.HasValue && b.HasValue && c.HasValue)
            {
                var result = "Error";

                if (a.Value == b.Value && a.Value == c.Value)
                    result = "Equilateral";
                else if ((a.Value == b.Value && a.Value > c.Value / 2) ||
                    (c.Value == b.Value && c.Value > a.Value / 2))
                    result = "Isosceles";
                else if (a.Value != b.Value && a.Value != c.Value && b.Value != c.Value)
                    result = "Scalene";
                //else if (Math.Pow(c.Value, 2) == (Math.Pow(a.Value, 2) + Math.Pow(b.Value, 2)))
                //    result = "Right";
                //else if (Math.Pow(c.Value, 2) < (Math.Pow(a.Value, 2) + Math.Pow(b.Value, 2)))
                //    result = "Acute";
                //else if (Math.Pow(c.Value, 2) > (Math.Pow(a.Value, 2) + Math.Pow(b.Value, 2)))
                //    result = "Obtuse";

                return Ok(result);
            }
            return BadRequest("The request is invalid.");

        }
    }
}
