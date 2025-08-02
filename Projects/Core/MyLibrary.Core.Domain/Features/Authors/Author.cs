using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Core.Domain.Features.Authors;

/// <summary>
/// Represents a person who writes books.
/// </summary>
public record Author : BaseContract<string>
{
    /// <summary>
    /// The first names of the author, which may include multiple names or initials.
    /// </summary>
    /// <example>J.K.</example>
    public string? FirstNames { get; set; }

    /// <summary>
    /// The last names of the author, which may include multiple names or initials.
    /// </summary>
    /// <example>Rowling</example>
    public string? LastNames { get; set; }

    /// <summary>
    /// The preferred name of the author, which may be a nickname or a commonly used name that differs from their full name.
    /// </summary>
    /// <example>J.K. Rowling</example>
    public string? PreferredName { get; set; }

    /// <summary>
    /// An array of books written by the author.
    /// </summary>
    public List<string>? BookIds { get; set; }
}
