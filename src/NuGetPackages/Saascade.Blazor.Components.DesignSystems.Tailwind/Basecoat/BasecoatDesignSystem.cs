using Humanizer;
using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components;
using Saascade.Blazor.Components.Extensions;
using Saascade.Blazor.Components;

namespace Saascade.Blazor.Components.DesignSystems.Tailwind.Basecoat;

//https://basecoatui.com/
public class BasecoatDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Tailwind;
    public string DisplayName { get; } = nameof(BasecoatDesignSystem).Replace("DesignSystem", "").Humanize();

    public string? GetComponentName(BaseComponent component)
    => component.GetStandardizedComponentName() ?? component.GetType().Name switch
    { 
        _ => null
    };

    public string? GetSpecializations<T>(T component) where T : BaseComponent
    => component.GetType().Name switch
    {
        nameof(PrimaryButton) => "btn-primary",
        nameof(SecondaryButton) => "btn-secondary",
        nameof(DestructiveButton) => "btn-destructive",
        nameof(AcceptButton) => "btn-success",
        nameof(SubmitButton) => "btn-primary",
        nameof(CloseButton) => "btn-secondary",
        nameof(CancelButton) => "btn-secondary",
        nameof(DeleteButton) => "btn-destructive", 
        _ => null
    };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
    => component.GetType().Name switch
    {
        _ => null
    };
     

    public string[] GetStylesheetReferences() => 
    [
        """ <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/basecoat-css@0.3.11/dist/basecoat.cdn.min.css"> """ 
    ];

    public string[] GetJavaScriptReferences() => 
    [ 
        """ <script src="https://cdn.jsdelivr.net/npm/basecoat-css@0.3.11/dist/js/all.min.js" defer></script> """
    ];
}