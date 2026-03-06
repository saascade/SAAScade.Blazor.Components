using Humanizer;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection; 

namespace Saascade.Blazor.Components.Base;

public abstract class BaseComponent : ComponentBase
{
    [Parameter]
    [CascadingParameter(Name = "Parent")]
    public virtual BaseComponent? Parent { get; set; }

    [Parameter] public virtual string? Id { get; set; }
    [Parameter] public virtual string? Name { get; set; }
    [Parameter] public virtual string? Class { get; set; }
    [Parameter] public virtual string? Style { get; set; }
    [Parameter] public virtual string? Tooltip { get; set; }
    [Parameter] public virtual string? AriaLabel { get; set; }
    [Parameter] public virtual string? AriaLabelledby { get; set; }
    [Parameter] public virtual string? AriaRole { get; set; }

//    [Parameter] public virtual Dictionary<string, string> Data { get; set; } = [];

    protected string componentLibraryCssClasses = "NOT SET";

    //TODO: can't do this yet: [Inject(optional = true)] protected IComponentLibrary? CssNamingConvention { get; set; }
    //So need to use IServiceProvider directly for now as a workaround
    [Inject] private IServiceProvider serviceProvider { get; set; }


    protected override Task OnParametersSetAsync()
    {
        componentLibraryCssClasses = GetComponentLibraryCssClasses();

        //Name ??= GetType().Name;
        //Name = Name?.ToLowerSnakeCase();

        return base.OnParametersSetAsync();
    }

    private string GetComponentLibraryCssClasses()
    {
        var componentLibrary = serviceProvider.GetService<IComponentLibrary>();
        return componentLibrary != null 
            ? componentLibrary.GetClassesForComponent(this) 
            : string.Empty;
    }

    protected string? GetFullname()
    {
        if (Name is null) { return null; }

        var parentFullName = RecursivelyGetLastParentFullname(this);
        if (parentFullName is not null)
        {
            var fullName = parentFullName + "." + Name;
            return fullName;
        }

        return Name;
    }

    private static string? RecursivelyGetLastParentFullname(BaseComponent? component)
    {
        if (component is null) { return null; }
        //if () { return null; }
                
        if (component.Parent?.Name is null)
        {
            //If the current parent doesn't have a name, assume it is just for formatting so skip it
            //and go further up the tree looking for a parent with a name

            return RecursivelyGetLastParentFullname(component.Parent);
        }
        else
        {
            var parentFullName = component.Parent?.GetFullname();
            return parentFullName;
        }
    }


    protected string GetFinalClassNames()
    {
        return $"{Class?.Trim()} {componentLibraryCssClasses.Trim()}".Trim();
    }

    //private string? GetIdAttribute() => GetAttribute("id", Id);
    //private string? GetStyleAttribute() => GetAttribute("style", Style);
    //private string? GetTooltipAttribute() => GetAttribute("title", Tooltip);
    //private string? GetAttribute(string name, string value) => string.IsNullOrWhiteSpace(Id) ? null : $@"{name}=""{value}""";

    //private string? GetOtherDataAttributes()
    //{
    //    if (Data.Count == 0) { return null; }
    //    return string.Join(" ", Data.Select(d => $@"data-{d.Key}=""{d.Value}"""));
    //}
}
