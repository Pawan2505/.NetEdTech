using Microsoft.EntityFrameworkCore;
using MVCArchitecure.Context;
using MVCArchitecure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Register DbContext

var connectionString = builder.Configuration.GetConnectionString("TutorialDbConnection");

builder.Services.AddDbContext<TutorialDbContext>(Options => Options.UseSqlServer
(connectionString));

builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
