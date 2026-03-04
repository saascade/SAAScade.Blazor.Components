using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.ComponentLibraries;
using Saascade.Blazor.Components.Documentation.Website.Wasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

services.AddSingleton<IComponentLibrary, DaisyUIComponentLibrary>();


await builder.Build().RunAsync();
