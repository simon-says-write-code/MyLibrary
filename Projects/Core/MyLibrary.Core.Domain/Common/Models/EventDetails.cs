namespace MyLibrary.Core.Domain.Common.Models;

/// <summary>
/// Contains of an event (e.g. creation, modification) that occurred in the system.
/// </summary>
public record EventDetails
{
    /// <summary>
    /// The date and time the event happened.
    /// </summary>
    /// <example>25/12/2005 7:00:00 AM +00:00</example>
    public DateTimeOffset? Timestamp { get; init; }

    /// <summary>
    /// The identifier of the profile who triggered the event.
    /// </summary>
    /// <example>joe-bloggs</example>
    public string? ProfileId { get; init; }

    /// <summary>
    /// The name of the profile who triggered the event.
    /// </summary>
    /// <example>Joe Bloggs</example>
    public string? ProfileName { get; init; }
}
