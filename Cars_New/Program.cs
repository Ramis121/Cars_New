using Cars_New.DATA;
using Cars_New.Service;
using Domain.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//string connection = builder.Configuration.GetConnectionString("BloggingDatabase");
builder.Services.AddTransient<IRepository, RepositoryCars>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddDbContext<CarDbContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("BloggingDatabase"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

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
