global using BlazorAutoOA.Client.Services.VehicleServices;
global using BlazorAutoOA.Shared;
using BlazorAutoOA;
using BlazorAutoOA.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IVehicleServices, VehicleServices>();

await builder.Build().RunAsync();
