using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components.Base;

public abstract class BaseComponentWithRequiredChildContent : BaseComponent
{
    [Parameter, EditorRequired] public required RenderFragment ChildContent { get; set; }
}
