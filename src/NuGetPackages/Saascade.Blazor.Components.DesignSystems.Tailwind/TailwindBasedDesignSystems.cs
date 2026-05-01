using Saascade.Blazor.Components.DesignSystems.Tailwind.Basecoat;
using Saascade.Blazor.Components.DesignSystems.Tailwind.DaisyUI; 

namespace Saascade.Blazor.Components.DesignSystems.Tailwind;

public class TailwindBasedDesignSystems
{
    public static readonly TailwindBasedDesignSystems Instance = new ();
    private TailwindBasedDesignSystems(){}
    
    //https://www.reddit.com/r/tailwindcss/comments/1mkso56/best_tailwind_component_libraries_free/
    public IDesignSystem DaisyUI = new DaisyUiDesignSystem();
    public IDesignSystem Basecoat = new BasecoatDesignSystem(); 
}
