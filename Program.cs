using CustomerCareWebApp.BAL;
using CustomerCareWebApp.DAl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CustomercareDbContext>(x => x.UseSqlServer(
    builder.Configuration.GetConnectionString("ccdb1"))
    );

builder.Services.AddScoped<IAccountrepository, ACCOUNTRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
