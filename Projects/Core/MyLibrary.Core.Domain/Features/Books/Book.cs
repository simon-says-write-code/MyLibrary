using MyLibrary.Core.Domain.Common.Abstractions;

namespace MyLibrary.Core.Domain.Features.Books;

/// <summary>
/// Represents a book in the library system.
/// </summary>
public record Book : BaseContract<string>
{
    /// <summary>
    /// The name of the book.
    /// </summary>
    /// <example>Harry Potter and the Philosopher's Stone</example>
    public string? Title { get; init; }

    /// <summary>
    /// The author.
    /// </summary>
    /// <example>J.K. Rowling</example>
    public string? AuthorId { get; init; }

    /// <summary>
    /// A short description of the book.
    /// </summary>
    /// <example>
    /// It follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday 
    /// when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. 
    /// Harry makes close friends and a few enemies during his first year at the school. 
    /// With the help of his friends, Ron Weasley and Hermione Granger, he faces an attempted comeback by the dark wizard Lord Voldemort, 
    /// who killed Harry's parents but failed to kill Harry when he was just 15 months old.
    /// </example>
    public string? Description { get; init; }

    /// <summary>
    /// The date when the book was published.
    /// </summary>
    /// <example>26-06-1996</example>
    public DateOnly? PublishedDate { get; init; }

    /// <summary>
    /// The genres this book is associated with.
    /// </summary>
    /// <example>[ "Fantasy" ]</example>
    public string[]? GenreIds { get; init; }

    /// <summary>
    /// The number of pages this book has.
    /// </summary>
    /// <example>223</example>
    public int? Pages { get; init; }
}
