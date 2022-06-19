namespace KennisbeursGrimbergen.Models.User;

public class PermissionsUserModel
{
    public long UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }

    public bool HasUserReadOnlyRole { get; set; }
    public bool HasUserRole { get; set; }
    public bool HasManagerRole { get; set; }
    public bool HasAdminRole { get; set; }
}
