
using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components;

public abstract class BaseComponent : ComponentBase
{
    [Parameter]
    [CascadingParameter(Name = "Parent")]
    public virtual BaseComponent? Parent { get; set; }

    [Parameter] public virtual string? Id { get; set; }
    [Parameter] public virtual string? Name { get; set; }
    [Parameter] public virtual string? Class { get; set; } 
    [Parameter] public virtual string? Specialization { get; set; }
    [Parameter] public virtual string? Style { get; set; } 
    [Parameter] public virtual string? Tooltip { get; set; }
    [Parameter] public virtual string? AriaLabel { get; set; }
    [Parameter] public virtual string? AriaLabelledby { get; set; }
    [Parameter] public virtual string? AriaRole { get; set; }

//    [Parameter] public virtual Dictionary<string, string> Data { get; set; } = [];

 
    //TODO: can't do this yet: [Inject(optional = true)] protected IComponentLibrary? CssNamingConvention { get; set; }
    //So need to use IServiceProvider directly for now as a workaround
    //[Inject] private IServiceProvider serviceProvider { get; set; }
      
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
        try
        {
            var componentName = DesignSystem.GetComponentName(this);
            string designSystemSpecializationClasses = DesignSystem.GetSpecializations(this)?.Trim();
            string userSuppliedClasses = Class?.Trim();
            string[] userSuppliedSpecializations = GetUserSuppliedSpecializationsPrefixedWithComponentName(componentName).ToArray();
            var userSuppliedSpecializationsAtText = string.Join(" ", userSuppliedSpecializations);
            var result = $"{componentName} {userSuppliedClasses} {userSuppliedSpecializationsAtText} {designSystemSpecializationClasses}".Trim();
            return result;
        }
        catch (Exception ex)
        {

            throw;
        } 
    }


    private IEnumerable<string> GetUserSuppliedSpecializationsPrefixedWithComponentName(string componentName)
    {
        if (string.IsNullOrWhiteSpace(Specialization)) { yield break; }

        var specializations = Specialization.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var componentNamePrefix = $"{componentName}-";
        foreach (var specialization in specializations)
        {
            if (specialization.StartsWith(componentNamePrefix))
            {
               yield return specialization;
            }
            else
            {
                yield return $"{componentNamePrefix}{specialization}";
            }
        }
    }


    [Inject] public required IDesignSystem DesignSystem { get; set; }




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
