using Microsoft.AspNetCore.Components;
namespace Saascade.Blazor.Components;

public partial class Render : ComponentBase
{
    [Parameter, EditorRequired] public bool When { get; set; }
    [Parameter, EditorRequired] public RenderFragment ChildContent { get; set; }
}