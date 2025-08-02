using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Core.Domain.Features.Authors;

/// <summary>
/// Represents a person who writes books.
/// </summary>
public class AuthorEntity : BaseEntity<string>
{
    /// <summary>
    /// The first names of the author, which may include multiple names or initials.
    /// </summary>
    public string? FirstNames { get; init; }

    /// <summary>
    /// The last names of the author, which may include multiple names or initials.
    /// </summary>
    public string? LastNames { get; init; }

    /// <summary>
    /// The preferred name of the author, which may be a nickname or a commonly used name that differs from their full name.
    /// </summary>
    public string? PreferredName { get; init; }

    /// <summary>
    /// An array of books written by the author.
    /// </summary>
    public List<string>? BookIds { get; init; }
}
