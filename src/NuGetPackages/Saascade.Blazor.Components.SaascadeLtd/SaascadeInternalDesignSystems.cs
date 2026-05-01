using Saascade.Blazor.Components.SaascadeLtd.SaascadeLtd;

namespace Saascade.Blazor.Components.SaascadeLtd;

public class SaascadeInternalDesignSystems
{
    public static readonly SaascadeInternalDesignSystems Instance = new ();
    private SaascadeInternalDesignSystems(){}
    
    public IDesignSystem ElectricBlueV1 = new ElectricBlueV1DesignSystem();
}
