using Humanizer;
using Saascade.Blazor.Components.Base;

namespace Saascade.Blazor.Components.ComponentLibraries;
 
public class DaisyUIComponentLibrary : IComponentLibrary
{
    public ComponentLibraryFoundation Foundation { get; } = ComponentLibraryFoundation.Tailwind;

    public string GetClassesForComponent<T>(T component) where T : BaseComponent
        => component.GetType().Name switch
        {
            nameof(Button) => "btn",
            nameof(Card) => "card bg-base-100 w-96 shadow-sm",
            nameof(Carousel) => "carousel rounded-box",
            nameof(Hero) => "hero bg-base-200 min-h-screen",
            _ => component.GetType().Name.ToLowerSnakeCase()
        };
     
}