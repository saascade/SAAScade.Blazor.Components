using Saascade.Blazor.Components.Base; 

namespace Saascade.Blazor.Components.ComponentLibraries;

public class VanillaCssComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Vanilla;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetType().Name switch
        {
            _ => component.GetType().Name.ToLowerSnakeCase()
        };

    public string? GetStyleForComponent<T>(T component) where T : BaseComponent => null;
}