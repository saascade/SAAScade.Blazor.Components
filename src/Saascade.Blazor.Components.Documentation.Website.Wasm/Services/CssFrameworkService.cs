namespace Saascade.Blazor.Components.Documentation.Website.Wasm.Services;

public class CssFrameworkService
{
    public IReadOnlyCollection<CssFramework> GetCssFrameworksToShow()
    { 
        return Enum.GetValues<CssFramework>();
        //return [CssFramework.SaascadeLtd];  
        //return Enum.GetValues<CssFramework>().Where(f => f != CssFramework.SaascadeLtd).ToList();
    }
}