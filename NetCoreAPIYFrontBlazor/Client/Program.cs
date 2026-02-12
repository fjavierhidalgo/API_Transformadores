using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NetCoreAPIYFrontBlazor.Client;
using NetCoreAPIYFrontBlazor.Client.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITransformadoresService, TransformadoresService>();
builder.Services.AddScoped<IInputsDataService, InputsDataService>();
builder.Services.AddScoped<IHiVoltagesService, HiVoltagesService>();


await builder.Build().RunAsync();

