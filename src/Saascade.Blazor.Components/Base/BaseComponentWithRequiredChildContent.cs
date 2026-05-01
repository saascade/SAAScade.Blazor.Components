using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components;

public abstract class BaseComponentWithRequiredChildContent : BaseComponent
{
    [Parameter, EditorRequired] public required RenderFragment ChildContent { get; set; }
}
