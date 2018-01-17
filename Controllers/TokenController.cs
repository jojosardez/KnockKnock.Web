using Microsoft.AspNetCore.Mvc;

namespace KnockKnock.Web.Controllers
{
    [Route("api/Token")]
    public class TokenController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("4fcf2414-6c0c-4406-b31f-20384b5d7bf9");
        }
    }
}
