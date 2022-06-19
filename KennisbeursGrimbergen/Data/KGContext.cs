using KennisbeursGrimbergen.Entities;
using KennisbeursGrimbergen.Identity.Entities;
using KennisbeursGrimbergen.Localizers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KennisbeursGrimbergen.Data;

public class KGContext : IdentityDbContext<User, Role, long> // KG = KennisbeursGrimbergen
{
    public DbSet<Activity> Activities { get; set; } = null!;
    public DbSet<Translation> Translations { get; set; } = null!;

    public KGContext(DbContextOptions<KGContext> options) : base(options)
    {
        //
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Translation>().HasData(
            KGLocalizer.DefaultTranslations()
        );

        builder.Entity<Activity>().HasData(
            new Activity
            {
                Id = 1,
                Title = "Activiteit Bridge (samenwerking Ter Borre)",
                Animator = "Francis Aelbers",
                Email = "f.aelbers@scarlet.be",
                Description = "",
                UserId = 2,
                Date = "donderdag 07/07/2022	14 - 16.30",
                Location = "Dienstencentrum Ter Borre",
            },
            new Activity
            {
                Id = 2,
                Title = "Activiteit Lezingen",
                Animator = "Edwin Van Geert",
                Email = "edwin.van.geert@skynet.be",
                Description = "",
                UserId = 2,
                Date = "Maandag 07/09/2022	14 - 16.30",
                Location = "Dienstencentrum Ter Borre",
            },
            new Activity
            {
                Id = 3,
                Title = "Activiteit Schaken",
                Animator = "Ivan Van Malderen",
                Email = "ivan.van.malderen@telenet.be",
                Description = "",
                UserId = 2,
                Date = "Vrijdag 27/07/2022	14 - 16.30",
                Location = "Dienstencentrum Ter Borre",
            }
        );
    }
}