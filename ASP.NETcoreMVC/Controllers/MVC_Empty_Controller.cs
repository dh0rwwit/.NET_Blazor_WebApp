using Microsoft.AspNetCore.Mvc;

namespace ASP.NETcoreMVC.Controllers
{
    public class MVC_Empty_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok(new { message = "Hello from ASP.NET Core!" });
        }

        [HttpPost("echo")]
        public IActionResult Echo([FromBody] object data)
        {
            return Ok(new { received = data });
        }


    }
}
