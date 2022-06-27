using System.Diagnostics;
using cwiczenia10_mp_s23525.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cwiczenia10_mp_s23525.Models;

namespace cwiczenia10_mp_s23525.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}