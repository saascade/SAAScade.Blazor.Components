using Humanizer;
using Saascade.Blazor.Components;
using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components;
using Saascade.Blazor.Components.Extensions;
using System.ComponentModel;

namespace Saascade.Blazor.DesignSystems.Tailwind.DaisyUI;

//https://daisyui.com/components/button/
public class DaisyUiDesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Tailwind;

    public string GetComponentName(BaseComponent component)
    => component.GetStandardizedComponentName() ?? component.GetType().Name switch
    {
        nameof(A) => "link",
        _ => component.GetType().Name.ToLowerSnakeCase()
    };

    public string? GetSpecializations<T>(T component) where T : BaseComponent
    => component.GetType().Name switch
    {
        nameof(PrimaryButton) => "btn-primary",
        nameof(SecondaryButton) => "btn-secondary",
        nameof(DestructiveButton) => "btn-error",
        nameof(AcceptButton) => "btn-success",
        nameof(SubmitButton) => "btn-primary",
        nameof(CloseButton) => "btn-secondary",
        nameof(CancelButton) => "btn-secondary",
        nameof(DeleteButton) => "btn-error",

        nameof(Card) => "bg-base-100 w-96 shadow-sm",
        nameof(Carousel) => "rounded-box",
        nameof(Hero) => "bg-base-200 min-h-screen",
        _ => null
    };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
    => component.GetType().Name switch
    {
        _ => null
    }; 

    public string[] GetStylesheetReferences() => 
    [
        """ <link href="https://cdn.jsdelivr.net/npm/daisyui@5" rel="stylesheet" type="text/css" /> """
    ];

    public string[] GetJavaScriptReferences() => 
    [
        """ <script src="https://cdn.jsdelivr.net/npm/@@tailwindcss/browser@4"></script> """,
    ];


}