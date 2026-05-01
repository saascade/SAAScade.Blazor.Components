using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Extensions;

namespace Saascade.Blazor.Components.Bootstrap5.Vanilla;

public class VanillaBootstrap5DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.Bootstrap5;


    public string GetComponentName(BaseComponent component)
    => component.GetStandardizedComponentName() ?? component.GetType().Name switch
    {
        nameof(Column) => "col",
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
     

    public string[] GetStylesheetReferences() => [];
    public string[] GetJavaScriptReferences() => [];
}
