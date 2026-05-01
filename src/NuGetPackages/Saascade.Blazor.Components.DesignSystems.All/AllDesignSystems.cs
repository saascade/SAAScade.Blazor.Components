using Saascade.Blazor.Components.DesignSystems.Bootstrap4;
using Saascade.Blazor.Components.DesignSystems.Bootstrap5;
using Saascade.Blazor.Components.DesignSystems.Tailwind;
using Saascade.Blazor.Components.DesignSystems.VanillaCss; 

namespace Saascade.Blazor.Components.DesignSystems.All;

public static class AllDesignSystems
{  
    public static Bootstrap4BasedDesignSystems Bootstrap4 = Bootstrap4BasedDesignSystems.Instance; 
    public static Bootstrap5BasedDesignSystems Bootstrap5 = Bootstrap5BasedDesignSystems.Instance; 
    public static TailwindBasedDesignSystems Tailwind = TailwindBasedDesignSystems.Instance; 
    public static VanillaCssBasedDesignSystems VanillaCss = VanillaCssBasedDesignSystems.Instance; 
}