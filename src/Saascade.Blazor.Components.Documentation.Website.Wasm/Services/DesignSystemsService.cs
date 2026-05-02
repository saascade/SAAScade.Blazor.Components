using System.Reflection;

namespace Saascade.Blazor.Components.Documentation.Website.Wasm.Services;

public class DesignSystemsService
{ 
    public IReadOnlyCollection<IDesignSystem> GetAllDesignSystems(CssFramework framework, bool verify)
    {
        var designSystems = GetAllDesignSystems(framework);
        if (verify)
        { 
            foreach (var designSystem in designSystems)
            {
                if (designSystem.CssFramework != framework)
                {
                    throw new NotSupportedException(
                        $"The design system {designSystem.GetType().Name} is not setup correctly. It's CSS Framework is incorrect.");
                }
            }
        }

        return designSystems; 
    }

    public IReadOnlyCollection<IDesignSystem> GetAllDesignSystems(CssFramework framework) 
        => ReflectionHelper.CreateAllImplementations<IDesignSystem>(GetDesignSystemAssemblies())
                            .Where(ds => ds.CssFramework == framework)
                            .ToList();
  
    
    public static Assembly[] GetDesignSystemAssemblies() =>
    [
        typeof(Saascade.Blazor.Components.DesignSystems.Tailwind._Imports).Assembly,
        typeof(Saascade.Blazor.Components.DesignSystems.VanillaCss._Imports).Assembly,
        typeof(Saascade.Blazor.Components.DesignSystems.Bootstrap5._Imports).Assembly,
        typeof(Saascade.Blazor.Components.DesignSystems.Bootstrap4._Imports).Assembly,
        typeof(Saascade.Blazor.Components.DesignSystems.SaascadeLtd._Imports).Assembly, 
    ];
}