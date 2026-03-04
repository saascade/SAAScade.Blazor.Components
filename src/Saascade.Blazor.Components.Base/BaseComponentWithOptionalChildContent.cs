using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components.Base;

public abstract class BaseComponentWithOptionalChildContent : BaseComponent
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
}
