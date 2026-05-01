using Saascade.Blazor.Components.Aliases; 
using Saascade.Blazor.Components.Extensions;

namespace Saascade.Blazor.Components.Vanilla.Handdrawn;

public class HanddrawnBlackAndWhiteDesignSystem : IDesignSystem
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
        nameof(PrimaryButton) => "btn-primary",
        nameof(SecondaryButton) => "btn-secondary",
        nameof(DestructiveButton) => "btn-error",
        nameof(AcceptButton) => "btn-success",
        nameof(SubmitButton) => "btn-primary",
        nameof(CloseButton) => "btn-secondary",
        nameof(CancelButton) => "btn-secondary",
        nameof(DeleteButton) => "btn-error",
        _ => null
    };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent
    => component.GetType().Name switch
    {
        _ => null
    };


    public string[] GetStylesheetReferences() =>
        [
        """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.Vanilla/handdrawn/css/basic.css" /> """,
        """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.Vanilla/handdrawn/css/handdrawn.bw.min.css" /> """
        ];
    public string[] GetJavaScriptReferences() => [];
}