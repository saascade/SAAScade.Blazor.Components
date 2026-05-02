using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace Saascade.Blazor.Components.Documentation.Website.Wasm.Services;

public class SaascadeComponentsService
{
    public static Assembly[] GetComponentsAsemblies() =>
    [
        typeof(Saascade.Blazor.Components._Imports).Assembly,
        typeof(Saascade.Blazor.Components.Experimental._Imports).Assembly
    ];

    public IReadOnlyCollection<BaseComponent> GetAllComponents() 
        => ReflectionHelper.CreateAllImplementations<BaseComponent>(GetComponentsAsemblies()).Where(Filter).ToList();

    public IReadOnlyCollection<Type> GetAllComponentsTypes() 
        => ReflectionHelper.GetAllImplementingTypes<BaseComponent>(GetComponentsAsemblies()).Where(Filter).ToList();


    private bool Filter(BaseComponent component)
        => Filter(component.GetType());
    
    private bool Filter(Type type)
    {
        //Filter out stuff we don't want to show
        if (!type.FullName.StartsWith("Saascade.Blazor.Components"))
        {
            return false;
        } 
        
        return true; 
    }
    
    
}