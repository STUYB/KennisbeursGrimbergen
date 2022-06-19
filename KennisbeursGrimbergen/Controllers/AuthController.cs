using KennisbeursGrimbergen.Identity.Entities;
using KennisbeursGrimbergen.Identity.Models;
using KennisbeursGrimbergen.Localizers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KennisbeursGrimbergen.Controllers;

public class AuthController : Controller
{
    public SignInManager<User> SignInManager { get; }
    public UserManager<User> UserManager { get; }
    public DatabaseStringLocalizerFactory Localizer { get; }

    public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, DatabaseStringLocalizerFactory localizer)
    {
        SignInManager = signInManager;
        UserManager = userManager;
        Localizer = localizer;
    }

    // Register
    public IActionResult Register() => View("Register");

    [HttpPost, AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Register(SignUpModel model)
    {
        ViewData["registrationError"] = "";
        ViewData["registrationSuccess"] = "";

        if (ModelState.IsValid is false)
        {
            return View(model);
        }

        var userFound = await UserManager.FindByEmailAsync(model.Email);
        if (userFound is not null)
        {
            ViewData["registrationError"] = Localizer.get("A user already exist with the same email address.");
        } else {
            var userCreated = await UserManager.CreateAsync(new User
            {
                UserName = model.UserName,
                Email = model.Email
            }, model.Password);

            if (userCreated.Succeeded)
            {
                ViewData["registrationSuccess"] = Localizer.get("Registration sent for approval.");
            } else {
                var reasons = userCreated.Errors.ToArray();
                var registrationError = "";
                foreach (var reason in reasons) {
                    registrationError = $"{registrationError} {Localizer.get(reason.Description)}";
                }
                ViewData["registrationError"] = $"{Localizer.get("Registration failed")}: { registrationError }";
            }
        }

        return View(model);
    }

    // Login
    [HttpGet, AllowAnonymous]
    public IActionResult Login(string redirectUrl) => View("Login",new SignInModel()
    {
        RedirectUrl = redirectUrl
    });

    [HttpPost, AllowAnonymous]
    public async Task<IActionResult> Login(SignInModel model)
    {
        ViewData["loginError"] = "";

        if (ModelState.IsValid is false)
        {
            return View(model);
        }

        var user = await UserManager.FindByNameAsync(model.UserName);

        if (user is null) { 
            ViewData["loginError"] = Localizer.get("User not found.");
            return View(model);
        }

        if (user.Approved == false) {
            ViewData["loginError"] = Localizer.get("User registration still processing..");
            return View(model);
        }

        var result = await SignInManager.PasswordSignInAsync(user, model.Password, isPersistent: true, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return Redirect(model.RedirectUrl ?? "/");
        } else {
            ViewData["loginError"] = Localizer.get("Login failed, make sure to provide the right credentials.");
            return View(model);
        }
    }

    // Logout
    public async Task<IActionResult> Logout()
    {
        await SignInManager.SignOutAsync();
        return Redirect("/");
    }

    // Forbidden
    public IActionResult Forbidden() => View();

}
