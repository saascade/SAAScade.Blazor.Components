using Microsoft.AspNetCore.Components;
using Saascade.Blazor.DesignSystems.Bootstrap5.Vanilla;  

namespace Saascade.Blazor.Components.Bootstrap5;

public class Bootstrap5BasedDesignSystems
{
    public static readonly Bootstrap5BasedDesignSystems Instance = new ();
    private Bootstrap5BasedDesignSystems(){}
    
    public IDesignSystem VanillaBootstrap5 = new VanillaBootstrap5DesignSystem();
}