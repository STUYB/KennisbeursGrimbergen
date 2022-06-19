using KennisbeursGrimbergen.Data;
using KennisbeursGrimbergen.Entities;
using KennisbeursGrimbergen.Identity.Entities;
using KennisbeursGrimbergen.Localizers;
using KennisbeursGrimbergen.Models.Activity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KennisbeursGrimbergen.Controllers;

[AllowAnonymous]
public class ActivitiesController : Controller
{
    public DatabaseStringLocalizerFactory Localizer { get; }
    private readonly ActivityRepository _activityRepository;
    public SignInManager<User> SignInManager { get; }
    public UserManager<User> UserManager { get; }

    public ActivitiesController(DatabaseStringLocalizerFactory localizer, ActivityRepository activityRepository, SignInManager<User> signInManager, UserManager<User> userManager)
    {
        Localizer = localizer;
        _activityRepository = activityRepository;
        SignInManager = signInManager;
        UserManager = userManager;
    }

    public IActionResult Index()
    {
        var activities = _activityRepository.FindAll();
        return View(activities);
    }

    public IActionResult Create()
    {
        return View("Create");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateAsync(CreateActivityModel model)
    {
        if (ModelState.IsValid is false)
        {
            return View(model);
        }

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        // Create payload
        var activity = new Activity
        {
            Title = model.Title,
            Description = model.Description,
            Animator = model.Animator,
            Email = model.Email,
            Date = model.Date,
            Location = model.Location,
            UserId = Convert.ToInt64(userId)
        };
        // Commit
        _activityRepository.Create(activity);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Detail(long Id)
    {
        if (Id == null || _activityRepository.FindOne() == null)
        {
            return NotFound();
        }
        var activity = _activityRepository.FindById(Id);
        if (activity == null)
        {
            return NotFound();
        }
        return View("Detail", activity);
    }
}
