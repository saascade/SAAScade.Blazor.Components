using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components;

public abstract class BaseComponentWithOptionalChildContent : BaseComponent
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}
