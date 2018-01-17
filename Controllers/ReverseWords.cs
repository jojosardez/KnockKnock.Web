using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockKnock.Web.Controllers
{
    [Route("api/ReverseWords")]
    public class ReverseWords : Controller
    {
        [HttpGet]
        public IActionResult Get(string sentence)
        {
            if (!string.IsNullOrEmpty(sentence))
            {
                char[] sentenceChars = sentence.ToCharArray();
                Array.Reverse(sentenceChars);
                string reversed = new string(sentenceChars);
                return Ok(reversed);
            }
            return Ok(string.Empty);
        }
    }
}
