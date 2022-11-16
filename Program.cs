using BackGroundServiceMessage.Data;
using BackGroundServiceMessage.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

IConfiguration _configuration=builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IDataService,DataService>();
builder.Services.AddSingleton<IComPortService, CompPortService>();
builder.Services.AddDbContext<Context>(option =>
{
    option.UseSqlite(_configuration["ConnectionStrings:Connection"]);
});

builder.Services.AddHostedService<SendMessage>();
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
