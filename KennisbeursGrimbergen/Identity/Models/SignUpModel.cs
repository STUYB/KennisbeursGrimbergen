namespace KennisbeursGrimbergen.Identity.Models;

using System.ComponentModel.DataAnnotations;

public class SignUpModel
{
    [Required, MinLength(3)]
    public string UserName { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required, MinLength(5)]
    public string Password { get; set; }
}