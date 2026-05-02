using System.ComponentModel;

namespace Saascade.Blazor.Components;

public enum CssFramework
{ 
    [Description("Vanilla CSS")]
    VanillaCss = 0, //None
    
    [Description("Tailwind")]
    Tailwind,
    
    [Description("Bootstrap 5")]
    Bootstrap5,
   
    [Description("Bootstrap 4")]
    Bootstrap4,
    
    [Description("SAAScade LTD")]
    SaascadeLtd
}
