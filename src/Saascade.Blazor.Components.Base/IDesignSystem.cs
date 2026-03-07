namespace Saascade.Blazor.Components.Base;

public interface IDesignSystem
{
    CssFramework CssFramework { get; }

    /// <summary>
    /// Must only return a single value 
    /// </summary>
    /// <param name="component"></param>
    /// <example>card</example>
    /// <example>btn</example>
    /// <returns></returns>
    string GetComponentName(BaseComponent component);

    /// <summary>
    /// Can return multiple values
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="component"></param>
    /// <example>bg-base-100 w-96 shadow-sm</example>
    /// <returns></returns>
    string? GetSpecializations<T>(T component) where T : BaseComponent;


    /// <summary>
    /// Can return multiple ;seperated values
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="component"></param>
    /// <example>--color1: red; font-size:16px</example>
    /// <returns></returns>
    string? GetStyleForComponent<T>(T component) where T : BaseComponent;

    string[] GetStylesheetReferences();
    string[] GetJavaScriptReferences();

}

