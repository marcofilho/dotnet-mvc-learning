using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvc.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

    }
}