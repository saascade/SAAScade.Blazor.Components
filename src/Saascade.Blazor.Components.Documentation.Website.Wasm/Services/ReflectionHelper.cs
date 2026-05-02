using System.Reflection;

namespace Saascade.Blazor.Components.Documentation.Website.Wasm.Services;

public static class ReflectionHelper
{
    public static IEnumerable<Type> GetAllImplementingTypes<TInterface>(params Assembly[] assemblies) 
    {
        var interfaceType = typeof(TInterface);
        if (assemblies.Length == 0)
        {
            assemblies = AppDomain.CurrentDomain.GetAssemblies();
        }

        var allTypesInAssemblies = assemblies.SelectMany(a =>
        {
            try
            {
                return a.GetTypes();
            }
            catch
            {
                return Array.Empty<Type>();
            }
        });
 
        var typesWeCareAbout = allTypesInAssemblies.Where(t =>
                interfaceType.IsAssignableFrom(t) &&
                t.IsClass &&
                !t.IsAbstract);
         
        return typesWeCareAbout;
    }
    
    
    public static IEnumerable<T> CreateAllImplementations<T>(params Assembly[] assemblies)
    { 
        var types = GetAllImplementingTypes<T>(assemblies); 
        // foreach (var type in types)
        // {
        //     try
        //     {
        //         var instance = Activator.CreateInstance(type);
        //         var c = (T)instance;
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         throw;
        //     } 
        // }
        
        return types.Select(t => (T)Activator.CreateInstance(t)!);
    }
     
}