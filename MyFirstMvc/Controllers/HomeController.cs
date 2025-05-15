using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Models;

namespace MyFirstMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var movie = new Movie
        {
            Title = "Inception",
            ReleaseDate = DateTime.Now,
            Genre = null,
            Price = 20000,
            Rating = 10
        };

        return RedirectToAction("Privacy", movie);
    }

    public IActionResult Privacy(Movie movie)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Index");
        }

        return View(movie);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
