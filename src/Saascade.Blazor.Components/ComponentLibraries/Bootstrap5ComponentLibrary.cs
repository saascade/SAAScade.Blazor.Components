using Saascade.Blazor.Components.Base;

namespace Saascade.Blazor.Components.ComponentLibraries;

public class Bootstrap5ComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Bootstrap5;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetType().Name switch
        {
            nameof(Button) => "btn",
            nameof(Card) => "card",
            nameof(Column) => "col",
            _ => component.GetType().Name.ToLowerSnakeCase()
        }; 
}
