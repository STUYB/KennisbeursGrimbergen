using KennisbeursGrimbergen.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace KennisbeursGrimbergen.Identity;

public static class KGIdentity
{
    // ROLES
    public const string ADMIN = "Adminstrator";
    public const string MANAGER = "Manager";
    public const string USER = "User";
    public const string USER_READ_ONLY = "UserReadOnly";

    // ROLES NORMALIZED
    public const string ADMIN_NORMALIZED = "ADMINSTRATOR";
    public const string MANAGER_NORMALIZED = "MANAGER";
    public const string USER_NORMALIZED = "USER";
    public const string USER_READ_ONLY_NORMALIZED = "USERREADONLY";

    // CLAIM TYPES
    public const string SYSTEM = "System";
    // public const string USER = "User";
    public const string ACTIVITY = "Activity";

    // CLAIM VALUES
    public const string CREATE = "Create";
    public const string UPDATE = "Update";
    public const string READ = "Read";
    public const string DELETE = "Delete";

    // DEFAULT ADMIN
    private const string ADMIN_USERNAME = "admin";
    private const string ADMIN_MAIL = "admin@kennisbeurs.grimbergen.be";
    private const string ADMIN_PASSWORD_HASH = "Admin123!";

    // DEFAULT MANAGER
    private const string MANAGER_USERNAME = "manager";
    private const string MANAGER_MAIL = "manager@kennisbeurs.grimbergen.be";
    private const string MANAGER_PASSWORD_HASH = "Manager123!";

    public static User[] DefaultUsers()
    {
        var users = new User[]
        {
            new User
            {
                UserName = ADMIN_USERNAME,
                Email = ADMIN_MAIL,
                PasswordHash = ADMIN_PASSWORD_HASH,
                Approved = true
            },
            new User
            {
                UserName = MANAGER_USERNAME,
                Email = MANAGER_MAIL,
                PasswordHash = MANAGER_PASSWORD_HASH,
                Approved = true
            }
        };
        return users;
    }

    public static Role[] DefaultRoles()
    {
        var roles = new Role[]
        {
            new Role
            {
                Name = ADMIN,
                NormalizedName = ADMIN_NORMALIZED
            },
            new Role
            {
                Name = MANAGER,
                NormalizedName = MANAGER_NORMALIZED
            },
            new Role
            {
                Name = USER,
                NormalizedName = USER_NORMALIZED
            },
            new Role
            {
                Name = USER_READ_ONLY,
                NormalizedName = USER_READ_ONLY_NORMALIZED
            }
        };
        return roles;
    }

    public static Dictionary<string, Claim[]> DefaultClaims()
    {
        var claims = new Dictionary<string, Claim[]>
        {
            {
                ADMIN,
                new Claim[]
                {
                    new Claim(SYSTEM, CREATE),
                    new Claim(SYSTEM, UPDATE),
                    new Claim(SYSTEM, READ),
                    new Claim(SYSTEM, DELETE),
                    new Claim(ACTIVITY, CREATE),
                    new Claim(ACTIVITY, UPDATE),
                    new Claim(ACTIVITY, READ),
                    new Claim(ACTIVITY, DELETE),
                }
            },
            {
                MANAGER,
                new Claim[]
                {
                    new Claim(USER, CREATE),
                    new Claim(USER, UPDATE),
                    new Claim(USER, READ),
                    new Claim(USER, DELETE),
                    new Claim(ACTIVITY, CREATE),
                    new Claim(ACTIVITY, UPDATE),
                    new Claim(ACTIVITY, READ),
                    new Claim(ACTIVITY, DELETE),
                }
            },
            {
                USER,
                new Claim[]
                {
                    new Claim(ACTIVITY, CREATE),
                    new Claim(ACTIVITY, UPDATE),
                    new Claim(ACTIVITY, READ),
                    new Claim(ACTIVITY, DELETE),
                }
            },
            {
                USER_READ_ONLY,
                new Claim[]
                {
                    new Claim(ACTIVITY, READ)
                }
            }
        };
        return claims;
    }

    public static async Task FactoryIdentitySettingAsync(IServiceScope scope)
    {
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();

        var users = DefaultUsers();
        var roles = DefaultRoles();
        var claims = DefaultClaims();

        foreach (var user in users)
        {
            if (await userManager.FindByNameAsync(user.UserName) is null)
            {
                var result = await userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded is false)
                {
                    throw new Exception($"Failed to add user {user.UserName}");
                }
            }
        }

        foreach (var role in roles)
        {
            if (await roleManager.FindByNameAsync(role.Name) is null)
            {
                var result = await roleManager.CreateAsync(role);
                if (result.Succeeded is false)
                {
                    throw new Exception($"Failed to add role {role.Name}");
                }

                if (claims.ContainsKey(role.Name))
                {
                    var dbRole = await roleManager.FindByNameAsync(role.Name);
                    foreach (var claim in claims[role.Name])
                    {
                        await roleManager.AddClaimAsync(dbRole, claim);
                    }
                }
            }
        }

        await userManager.AddToRoleAsync(await userManager.FindByNameAsync(ADMIN_USERNAME), ADMIN);
        await userManager.AddToRoleAsync(await userManager.FindByNameAsync(MANAGER_USERNAME), MANAGER);
    }
}