using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Core.Domain.Features.Books;

/// <summary>
/// Represents a book in the library system.
/// </summary>
public class BookEntity : BaseEntity<string>
{
    /// <summary>
    /// The name of the book.
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// The author.
    /// </summary>
    public string? AuthorId { get; init; }

    /// <summary>
    /// A short description of the book.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// The date when the book was published.
    /// </summary>
    public DateOnly? PublishedDate { get; init; }

    /// <summary>
    /// The genres this book is associated with.
    /// </summary>
    public string[]? GenreIds { get; init; }

    /// <summary>
    /// The number of pages this book has.
    /// </summary>
    public int? Pages { get; init; }
}
