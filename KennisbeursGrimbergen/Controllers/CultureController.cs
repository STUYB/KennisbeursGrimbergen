using KennisbeursGrimbergen.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace KennisbeursGrimbergen.Controllers;

[Authorize(Policy = Policies.Approved)]
public class CultureController : Controller
{
    private readonly ILogger<CultureController> _logger;

    public CultureController(ILogger<CultureController> logger)
    {
        _logger = logger;
    }

    [HttpGet, AllowAnonymous]
    public IActionResult English(string redirectUrl)
    {
        return setCulture("en-en");
    }

    [HttpGet, AllowAnonymous]
    public IActionResult Dutch(string redirectUrl)
    {
        return setCulture("nl-nl");
    }

    [HttpGet, AllowAnonymous]
    public IActionResult French(string redirectUrl)
    {
        return setCulture("fr-fr");
    }

    private IActionResult setCulture(string culture) {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMonths(1) }
        );
        return Redirect("/");
    }


}
