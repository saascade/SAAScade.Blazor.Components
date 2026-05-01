using Humanizer;
using Saascade.Blazor.Components.Aliases;

namespace Saascade.Blazor.Components;

public static class BaseComponentExtensions
{ 
    extension(BaseComponent component)
    {
        /// <summary>
        /// Returns css classes for H1-6.
        /// Otherwise returns null
        /// </summary>
        /// <returns></returns>
        public string? GetStandardizedComponentName() => component.GetType().Name switch
        {
            nameof(H1) => "h1",
            nameof(H2) => "h2",
            nameof(H3) => "h3",
            nameof(H4) => "h4",
            nameof(H5) => "h5",
            nameof(H6) => "h6",

            nameof(Button) => "btn",
            nameof(PrimaryButton) => "btn",
            nameof(SecondaryButton) => "btn",
            nameof(DestructiveButton) => "btn",
            nameof(AcceptButton) => "btn",
            nameof(SubmitButton) => "btn",
            nameof(CloseButton) => "btn",
            nameof(CancelButton) => "btn",
            nameof(DeleteButton) => "btn",
            _ => null
        };
    } 
}