using Saascade.Blazor.Components;
using Saascade.Blazor.Components.Extensions; 

namespace Saascade.Blazor.DesignSystems.Vanilla.Handdrawn;

public class HanddrawnAssessibleDesignSystem : IDesignSystem
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
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.Vanilla/handdrawn/css/basic.css" /> """,
            """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.Vanilla/handdrawn/css/handdrawn.assessible.min.css" /> """
        ];
    public string[] GetJavaScriptReferences() => [];


    private HanddrawnBlackAndWhiteDesignSystem handdrawn = new HanddrawnBlackAndWhiteDesignSystem();
}