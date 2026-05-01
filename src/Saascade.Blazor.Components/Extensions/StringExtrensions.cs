using Humanizer;

namespace Saascade.Blazor.Components.Extensions;

public static class StringExtensions
{

    //New (.Net 10) style to create extensions
    extension(string text)
    {
        public string ToLowerSnakeCase()
        {
            var underscoredWord = text.Humanize().Underscore();
            return underscoredWord.Hyphenate();
        }
    }


    //Previous style to create extension methods
    //public static string ToLowerSnakeCase(this string text)
    //{
    //    var underscoredWord = text.Humanize().Underscore();
    //    return underscoredWord.Hyphenate();
    //}
}