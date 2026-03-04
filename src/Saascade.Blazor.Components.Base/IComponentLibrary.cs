namespace Saascade.Blazor.Components.Base;

public interface IComponentLibrary
{
    ComponentLibraryFoundation Foundation { get; }
    string GetClassesForComponent<T>(T component) where T : BaseComponent;
    //string? GetStyleForComponent<T>(T component) where T : BaseComponent;
}

