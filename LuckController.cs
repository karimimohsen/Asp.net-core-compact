using Microsoft.AspNetCore.Mvc;

namespace WebServiceApplication
{
    public class LuckController : Controller
    {
        public IActionResult Try()
        {
            return Ok(42);
        }
    }
}