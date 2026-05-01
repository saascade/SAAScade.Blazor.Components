namespace Saascade.Blazor.Components;

public enum HyperlinkTarget
{
    Self = 0,
    Blank = 1,
    Parent = 2,
    Top = 3
}

public static class HyperlinkTargetResolver
{
    public static string Resolve(this HyperlinkTarget target) => target switch
    {
        HyperlinkTarget.Blank => "_blank",
        HyperlinkTarget.Parent  => "_parent",
        HyperlinkTarget.Top => "_top",
        HyperlinkTarget.Self => "_self",
        _ => "_self"
    };
} 