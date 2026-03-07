using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Base;
using Saascade.Blazor.Components.Base.Extensions;

namespace Saascade.Blazor.DesignSystems.Custom.Handdrawn;

public class HanddrawnColorDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Custom;
     

    public string GetComponentName(BaseComponent component)
    => handdrawn.GetComponentName(component) ?? component.GetType().Name switch
    {
        _ => component.GetType().Name.ToLowerSnakeCase()
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
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components/designSystems/custom/handdrawn/css/basic.css" /> """,
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components/designSystems/custom/handdrawn/css/handdrawn.color.min.css" /> """
        ];
    public string[] GetJavaScriptReferences() => [];

    private HanddrawnBlackAndWhiteDesignSystem handdrawn = new HanddrawnBlackAndWhiteDesignSystem();
}