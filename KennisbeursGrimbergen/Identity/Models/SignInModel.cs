namespace KennisbeursGrimbergen.Identity.Models;

using System.ComponentModel.DataAnnotations;

public class SignInModel
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public string? RedirectUrl { get; set; } = "/";
}