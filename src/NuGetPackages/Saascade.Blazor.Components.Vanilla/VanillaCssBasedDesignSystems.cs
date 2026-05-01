using Saascade.Blazor.DesignSystems.Custom.Vanilla;
using Saascade.Blazor.DesignSystems.Vanilla.Empty;  
using Saascade.Blazor.DesignSystems.Vanilla.Handdrawn; 

namespace Saascade.Blazor.Components.Vanilla;

public class VanillaCssBasedDesignSystems
{
    public static readonly VanillaCssBasedDesignSystems Instance = new ();
    private VanillaCssBasedDesignSystems(){}
    
    public IDesignSystem EmptyDesignSystem = new EmptyDesignSystem();
    public IDesignSystem Basic1 = new Basic1DesignSystem();
    public Handdrawn Handdrawn = new Handdrawn();
}

public class Handdrawn
{
    public IDesignSystem Assessible = new HanddrawnAssessibleDesignSystem();
    public IDesignSystem BlackAndWhite = new HanddrawnBlackAndWhiteDesignSystem();
    public IDesignSystem Color = new HanddrawnColorDesignSystem(); 
}