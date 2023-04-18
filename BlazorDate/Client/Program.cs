global using BlazorDate.Client.Services.PersonService;
global using BlazorDate.Client.Services.GenderService;
global using BlazorDate.Client.Services.PreferenceService;
global using BlazorDate.Client.Services.SeriousnessService;
global using BlazorDate.Shared;
global using BlazorDate.Shared.Models;
global using System.Net.Http.Json;
using BlazorDate.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IGenderService, GenderService>();
builder.Services.AddScoped<IPreferenceService, PreferenceService>();
builder.Services.AddScoped<ISeriousnessService, SeriousnessService>();


await builder.Build().RunAsync();
