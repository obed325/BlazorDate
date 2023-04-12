global using BlazorDate.Shared;
global using BlazorDate.Shared.Models;
global using BlazorDate.Server.Services.PersonService;
global using BlazorDate.Server.Services.GenderService;
global using BlazorDate.Server.Services.PreferenceService;
global using Microsoft.EntityFrameworkCore;
global using BlazorDate.Server.Data;
using Microsoft.AspNetCore.ResponseCompression;
//using BlazorDate.Server.Services.PreferenceService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IGenderService, GenderService>();
builder.Services.AddScoped<IPreferenceService, PreferenceService>();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();


app.MapFallbackToFile("index.html");

app.Run();
