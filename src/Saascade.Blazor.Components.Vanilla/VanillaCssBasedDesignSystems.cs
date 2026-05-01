using Saascade.Blazor.DesignSystems.Custom.Vanilla;
using Saascade.Blazor.DesignSystems.Vanilla.Empty;  
using Saascade.Blazor.DesignSystems.Vanilla.Handdrawn; 

namespace Saascade.Blazor.Components.Vanilla;

public class VanillaCssBasedDesignSystems
{
    public static readonly VanillaCssBasedDesignSystems Instance = new ();
    private VanillaCssBasedDesignSystems(){}
    
    public static IDesignSystem EmptyDesignSystem = new EmptyDesignSystem();
    public static IDesignSystem Basic1 = new Basic1DesignSystem();
  
    public static class Handdrawn
    {
        public static IDesignSystem Assessible = new HanddrawnAssessibleDesignSystem();
        public static IDesignSystem BlackAndWhite = new HanddrawnBlackAndWhiteDesignSystem();
        public static IDesignSystem Color = new HanddrawnColorDesignSystem(); 
    }
}
