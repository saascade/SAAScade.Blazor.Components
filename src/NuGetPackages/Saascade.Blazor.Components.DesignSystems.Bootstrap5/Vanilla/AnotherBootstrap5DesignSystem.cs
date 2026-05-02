using Humanizer; 

namespace Saascade.Blazor.Components.DesignSystems.Bootstrap5.Vanilla;

//This is just to show reusing the VanillaBootstrap5DesignSystem instead to repeating all the config again
public class AnotherBootstrap5DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Bootstrap5;
    public string DisplayName { get; } = nameof(AnotherBootstrap5DesignSystem).Replace("DesignSystem", "").Humanize();

 
    
    public string? GetComponentName(BaseComponent component)
    => vanillaBootstrap5.GetComponentName(component) ?? component.GetType().Name switch
    {
        _ => null
    };

    public string? GetSpecializations<T>(T component) where T : BaseComponent
    => vanillaBootstrap5.GetSpecializations(component) ?? component.GetType().Name switch
    {
        _ => null
    };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
    => vanillaBootstrap5.GetStyleForComponent(component) ?? component.GetType().Name switch
    {
        _ => null
    };


    public string[] GetStylesheetReferences() => [];
    public string[] GetJavaScriptReferences() => [];

    private VanillaBootstrap5DesignSystem vanillaBootstrap5 = new VanillaBootstrap5DesignSystem();
}
