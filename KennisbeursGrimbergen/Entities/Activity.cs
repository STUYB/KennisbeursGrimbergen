using KennisbeursGrimbergen.Identity.Entities;

namespace KennisbeursGrimbergen.Entities;

public class Activity : Entity
{
    // Properties
    public string Title { get; set; } = null!;
    public string Animator { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Date { get; set; } = null!;
    public string Location { get; set; } = null!;

    // Associations
    // 1 -> 1
    public long UserId { get; set; }
}