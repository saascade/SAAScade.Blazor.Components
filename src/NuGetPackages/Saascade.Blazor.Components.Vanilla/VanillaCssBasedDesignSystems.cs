using Saascade.Blazor.Components.Vanilla.Handdrawn;

namespace Saascade.Blazor.Components.Vanilla;

public class VanillaCssBasedDesignSystems
{
    public static readonly VanillaCssBasedDesignSystems Instance = new ();
    private VanillaCssBasedDesignSystems(){}
    
    public IDesignSystem EmptyDesignSystem = new EmptyDesignSystem();
    public IDesignSystem Basic1 = new Basic1DesignSystem();
    public HanddrawnDesignSystem Handdrawn = new HanddrawnDesignSystem();
}

public class HanddrawnDesignSystem
{
    public IDesignSystem Assessible = new HanddrawnAssessibleDesignSystem();
    public IDesignSystem BlackAndWhite = new HanddrawnBlackAndWhiteDesignSystem();
    public IDesignSystem Color = new HanddrawnColorDesignSystem(); 
}