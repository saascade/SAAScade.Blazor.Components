using Humanizer;
using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components;
using Saascade.Blazor.Components.Extensions;

namespace Saascade.Blazor.Components.DesignSystems.VanillaCss.Handdrawn;

public class HanddrawnColorDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.VanillaCss;
    public string DisplayName { get; } = nameof(HanddrawnColorDesignSystem).Replace("DesignSystem", "").Humanize();


    public string? GetComponentName(BaseComponent component)
    => handdrawn.GetComponentName(component) ?? component.GetType().Name switch
    {
        _ => null
    };

    public string? GetSpecializations<T>(T component) where T : BaseComponent
    => handdrawn.GetSpecializations(component) ?? component.GetType().Name switch
    {
        _ => null
    };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
    => handdrawn.GetStyleForComponent(component) ?? component.GetType().Name switch
    {
        _ => null
    };


    public string[] GetStylesheetReferences() => 
        [
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.DesignSystems.VanillaCss/handdrawn/css/basic.css" /> """,
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.DesignSystems.VanillaCss/handdrawn/css/handdrawn.color.min.css" /> """
        ];
    public string[] GetJavaScriptReferences() => [];

    private HanddrawnBlackAndWhiteDesignSystem handdrawn = new HanddrawnBlackAndWhiteDesignSystem();
}