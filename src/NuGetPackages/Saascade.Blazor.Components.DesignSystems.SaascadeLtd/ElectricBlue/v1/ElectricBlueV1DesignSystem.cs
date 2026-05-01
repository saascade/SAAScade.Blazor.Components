using Saascade.Blazor.Components.Aliases;
using Saascade.Blazor.Components.Extensions; 

namespace Saascade.Blazor.Components.DesignSystems.SaascadeLtd;

//https://daisyui.com/components/button/
public class ElectricBlueV1DesignSystem : IDesignSystem
{
    public CssFramework CssFramework { get; } = CssFramework.VanillaCss;


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
        """ <link rel="stylesheet" href="_content/Saascade.Blazor.Components.DesignSystems.SaascadeLtd/ElectricBlue/v1/css/styles.css" /> """,
    ];

    public string[] GetJavaScriptReferences() => [];
    
    public string[] GetFontReferences() =>
    [
        //TODO
        """ TODO href="_content/Saascade.Blazor.Components.DesignSystems.SaascadeLtd/shared/fonts/code.ttf" """,
    ];
}