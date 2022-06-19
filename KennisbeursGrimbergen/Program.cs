using KennisbeursGrimbergen.Data;
using KennisbeursGrimbergen.Identity;
using KennisbeursGrimbergen.Identity.Entities;
using KennisbeursGrimbergen.Localizers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

// Services
var builder = WebApplication.CreateBuilder(args);
// LOCALIZER
builder.Services
    .AddControllersWithViews()
    .AddMvcLocalization()
    .AddDataAnnotationsLocalization();
builder.Services.AddSingleton<DatabaseStringLocalizerFactory>();
builder.Services.AddSingleton<IStringLocalizerFactory>(provider => provider.GetRequiredService<DatabaseStringLocalizerFactory>());
builder.Services.AddRequestLocalization(options =>
{
    options.AddSupportedCultures("en", "nl", "fr");
    options.AddSupportedUICultures("en", "nl", "fr");
});
// DB
builder.Services.AddDbContext<KGContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
// AUTH
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(Policies.Approved, policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireRole(KGIdentity.ADMIN, KGIdentity.MANAGER, KGIdentity.USER, KGIdentity.USER_READ_ONLY);
    });
    options.DefaultPolicy = options.GetPolicy("Approved")!;
});
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<KGContext>();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Auth/Login";
    options.AccessDeniedPath = "/Auth/Forbidden";
});
// REPO
builder.Services.AddScoped<ActivityRepository>();
// APP
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Middlewares
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseRequestLocalization();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Init system users/roles/claims
await KGIdentity.FactoryIdentitySettingAsync(app.Services.CreateScope());


app.Run();
