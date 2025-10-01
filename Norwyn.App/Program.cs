using Microsoft.EntityFrameworkCore;
using Norwyn.App.Data;
using Norwyn.Services;
using Norwyn.Infrastructure.Repositories;
using Norwyn.Services.Account;
using Norwyn.Services.Users.Scripts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IUserService, UserService>();
 builder.Services.AddDbContext<ApplicationDbContext>(options =>
     options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
 builder.Services.AddScoped<IAccountService, AccountService>();
// builder.Services.AddScoped<ICityRollsService, CityRollsService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();