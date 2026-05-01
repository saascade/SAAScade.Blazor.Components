namespace Saascade.Blazor.Components.DesignSystems.SaascadeLtd;

public class SaascadeInternalDesignSystems
{
    public static readonly SaascadeInternalDesignSystems Instance = new ();
    private SaascadeInternalDesignSystems(){}
    
    public IDesignSystem ElectricBlueV1 = new ElectricBlueV1DesignSystem();
}
