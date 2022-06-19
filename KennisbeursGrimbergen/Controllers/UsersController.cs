using KennisbeursGrimbergen.Identity;
using KennisbeursGrimbergen.Identity.Entities;
using KennisbeursGrimbergen.Localizers;
using KennisbeursGrimbergen.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KennisbeursGrimbergen.Controllers;

[Authorize(Roles = KGIdentity.MANAGER)]
public class UsersController : Controller
{
    public SignInManager<User> SignInManager { get; }
    public UserManager<User> UserManager { get; }
    public DatabaseStringLocalizerFactory Localizer { get; }

    public UsersController(UserManager<User> userManager, SignInManager<User> signInManager, DatabaseStringLocalizerFactory localizer)
    {
        SignInManager = signInManager;
        UserManager = userManager;
        Localizer = localizer;
    }

    // Manage
    [HttpGet]
    public IActionResult Manage()
    {
        var users = UserManager.Users.ToList();
        return View("Manage", users);
    }

    // Approval
    // GET: Users/Approve/{id}
    [HttpGet]
    public async Task<IActionResult> ApproveAsync(long Id)
    {
        var user = await UserManager.FindByIdAsync(Id.ToString());
        return View("Approve", new ApproveUserModel
        {
            UserId = Id,
            UserName = user.UserName,
            Email = user.Email
        });
    }

    // POST: Users/Approve/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Approve(ApproveUserModel model, long Id)
    {
        TempData["manageSuccess"] = "";
        TempData["manageError"] = "";
        try
        {
            var user = await UserManager.FindByIdAsync(Id.ToString());
            user.Approved = true;
            await UserManager.UpdateAsync(user);
            TempData["manageSuccess"] = Localizer.get("User has been approved.");
        }
        catch (Exception)
        {
            TempData["manageError"] = Localizer.get("Failed to approve user.");
        }

        var users = UserManager.Users.ToList();
        return RedirectToAction("Manage", users);
    }

    // POST: Users/Reject/{id}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Reject(ApproveUserModel model, long Id)
    {
        TempData["manageSuccess"] = "";
        TempData["manageError"] = "";
        try
        {
            var user = await UserManager.FindByIdAsync(Id.ToString());
            await UserManager.DeleteAsync(user);
            TempData["manageSuccess"] = Localizer.get("User has been rejected.");
        }
        catch (Exception)
        {
            TempData["manageError"] = Localizer.get("Failed to reject user.");
        }

        var users = UserManager.Users.ToList();
        return RedirectToAction("Manage", users);
    }

    //Approval
    // GET: Users/Approve/{id}
    [HttpGet]
    public async Task<IActionResult> PermissionsAsync(long Id)
    {
        var user = await UserManager.FindByIdAsync(Id.ToString());
        var userRoles = await UserManager.GetRolesAsync(user);
        var roles = userRoles.ToArray();
        var adminChecked = false;
        var managerChecked = false;
        var userChecked = false;
        var userReadOnlyChecked = false;
        foreach (string role in roles)
        {
            switch (role)
            {
                case KGIdentity.USER_READ_ONLY:
                    userReadOnlyChecked = true;
                    break;
                case KGIdentity.USER:
                    userChecked = true;
                    break;
                case KGIdentity.MANAGER:
                    managerChecked = true;
                    break;
                case KGIdentity.ADMIN:
                    adminChecked = true;
                    break;
            }
        }
        return View("Permissions", new PermissionsUserModel
        {
            UserId = Id,
            UserName = user.UserName,
            Email = user.Email,
            HasAdminRole = adminChecked,
            HasManagerRole = managerChecked,
            HasUserRole = userChecked,
            HasUserReadOnlyRole = userReadOnlyChecked,
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SetPermissionAsync(PermissionsUserModel model, long Id)
    {
        TempData["manageSuccess"] = "";
        TempData["manageError"] = "";
        try
        {
            var user = await UserManager.FindByIdAsync(Id.ToString());
            var userRoles = await UserManager.GetRolesAsync(user);
            var roles = userRoles.ToArray();
            var rolesRemoved = await UserManager.RemoveFromRolesAsync(user, roles);
            if (model.HasUserReadOnlyRole)
            {
                await UserManager.AddToRoleAsync(user, KGIdentity.USER_READ_ONLY);
            }
            if (model.HasUserRole)
            {
                await UserManager.AddToRoleAsync(user, KGIdentity.USER);
            }
            if (model.HasManagerRole)
            {
                await UserManager.AddToRoleAsync(user, KGIdentity.MANAGER);
            }
            if (model.HasAdminRole)
            {
                await UserManager.AddToRoleAsync(user, KGIdentity.ADMIN);
            }
            var updated = await UserManager.UpdateAsync(user);
            if (updated.Succeeded)
            {
                TempData["manageSuccess"] = Localizer.get("User's permissions has been updated.");
            }
            else
            {
                TempData["manageError"] = Localizer.get("Failed to update user's permissions.");
            }
        }
        catch (Exception)
        {
            TempData["manageError"] = Localizer.get("Failed to update user's permissions.");
        }

        var users = UserManager.Users.ToList();
        return RedirectToAction("Manage", users);
    }

}
