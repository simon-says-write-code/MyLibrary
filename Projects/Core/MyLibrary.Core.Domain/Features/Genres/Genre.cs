using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Core.Domain.Features.Genres;

/// <summary>
/// Represents a categorization of books, such as Science Fiction, Fantasy, or Mystery.
/// </summary>
public record Genre : BaseContract<string>
{
    /// <summary>
    /// Name of the genre.
    /// </summary>
    /// <example>Science Fiction</example>
    public string? Name { get; init; }

    /// <summary>
    /// A short description of the genre, providing context or examples.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Tags associated with the genre, which can be used for filtering or searching.
    /// </summary>
    /// <example>[ "aliens", "fiction", "science", "space" ]</example>
    public string[]? Tags { get; init; }
}
