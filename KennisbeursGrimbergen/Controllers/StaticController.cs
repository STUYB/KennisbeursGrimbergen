using KennisbeursGrimbergen.Identity;
using KennisbeursGrimbergen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KennisbeursGrimbergen.Controllers;

[AllowAnonymous]
public class StaticController : Controller
{
    private readonly ILogger<StaticController> _logger;

    public StaticController(ILogger<StaticController> logger)
    {
        _logger = logger;
    }

    public IActionResult Objectives()
    {
        return View("Objectives");
    }

    public IActionResult Management()
    {
        return View("Management");
    }

    public IActionResult Links()
    {
        return View("Links");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
