using Saascade.Blazor.Components.Extensions; 

namespace Saascade.Blazor.Components.DesignSystems.SaascadeLtd;

//https://daisyui.com/components/button/
public class ElectricBlueV1DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Custom;


    public string GetComponentName(BaseComponent component)
        => component.GetStandardizedComponentName() ?? component.GetType().Name switch
        {
            _ => component.GetType().Name.ToLowerSnakeCase()
        };

    public string? GetSpecializations<T>(T component) where T : BaseComponent
        => component.GetType().Name switch
        { 
            _ => null
        };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
        => component.GetType().Name switch
        {
            _ => null
        };

    public string[] GetStylesheetReferences() => [];
    public string[] GetJavaScriptReferences() => [];
}