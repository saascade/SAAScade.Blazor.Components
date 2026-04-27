namespace Saascade.Blazor.Components.Documentation.Website.Wasm.Services;

public class TechFilterService
{
    public string SelectedTech { get; private set; } = "";
    public event Action? OnChange;

    public void Select(string tech)
    {
        SelectedTech = SelectedTech == tech ? "" : tech;
        OnChange?.Invoke();
    }

    public bool IsVisible(string cardTech) =>
        string.IsNullOrEmpty(SelectedTech) ||
        string.IsNullOrEmpty(cardTech) ||
        cardTech == SelectedTech;
}
