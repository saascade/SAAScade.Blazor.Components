using Humanizer;
using Saascade.Blazor.Components.Extensions;

namespace Saascade.Blazor.Components.DesignSystems.VanillaCss;

public class EmptyDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.VanillaCss;
    public string DisplayName { get; } = nameof(EmptyDesignSystem).Replace("DesignSystem", "").Humanize();


    public string? GetComponentName(BaseComponent component)
    => component.GetStandardizedComponentName() ?? component.GetType().Name switch
    {
        _ => null
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