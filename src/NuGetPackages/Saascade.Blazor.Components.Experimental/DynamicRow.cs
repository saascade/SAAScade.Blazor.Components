using System;
using System.Collections.Generic;

namespace Saascade.Blazor.Components;

public record DynamicRow 
(
    Guid Id,
    string? Label,
    Dictionary<string, object?> Values
);