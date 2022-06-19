using System.ComponentModel.DataAnnotations;

namespace KennisbeursGrimbergen.Models.Activity;

public class CreateActivityModel
{
    [Required, MaxLength(100)]
    public string? Title { get; set; }
    [Required, MaxLength(500)]
    public string? Description { get; set; }
    [Required]
    public string? Animator { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Date { get; set; }
    [Required]
    public string? Location { get; set; }
}
