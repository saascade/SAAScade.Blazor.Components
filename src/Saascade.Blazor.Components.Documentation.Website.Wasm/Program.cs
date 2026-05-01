using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Saascade.Blazor.Components;
using Saascade.Blazor.Components.DesignSystems;
using Saascade.Blazor.Components.Documentation.Website.Wasm;
using Saascade.Blazor.Components.Documentation.Website.Wasm.Services;
using Saascade.Blazor.Components.DesignSystems.SaascadeLtd;
using Saascade.Blazor.Components.DesignSystems.Tailwind;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var services = builder.Services;
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.RootComponents.Add<DesignSystemStylesheetReferences>("head::after");
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<DesignSystemJavaScriptReferences>("body::after");

services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
services.AddScoped<TechFilterService>();


//Pick a UI design system
//services.AddSingleton(TailwindBasedDesignSystems.Instance.DaisyUI);
//services.AddSingleton(AllDesignSystems.Tailwind.DaisyUI);
services.AddSingleton(SaascadeInternalDesignSystems.Instance.ElectricBlueV1);

await builder.Build().RunAsync();
