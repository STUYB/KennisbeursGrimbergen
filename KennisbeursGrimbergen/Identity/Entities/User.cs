namespace KennisbeursGrimbergen.Identity.Entities;

using Microsoft.AspNetCore.Identity;

public class User : IdentityUser<long>
{
    public bool Approved { get; set; } // Only approved users can sign in
}