namespace Saascade.Blazor.Components.Experimental;

/// <summary>
/// Represents a single playable media source with optional metadata. 
/// </summary>
public sealed record VideoSource
{
    /// <summary>
    /// URL to the media resource.
    /// </summary>
    public string Source { get; init; }

    /// <summary>
    /// MIME type (optional but recommended for progressive playback).
    /// Example: video/mp4, video/webm, application/x-mpegURL
    /// </summary>
    public string? Type { get; init; }

    public VideoSource(string source, string? type = null)
    {
        Source = source;
        Type = type;
    }
    
    public VideoSource(string source)
    {
        Source = source;
    }
}
