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

    /// <summary>
    /// Initializes a new instance of the <see cref="EventDetails"/> class with default values.
    /// </summary>
    public EventDetails()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventDetails"/> class with details from the supplied <paramref name="eventDetails"/> instance.
    /// </summary>
    /// <param name="eventDetails">The event details being copied.</param>
    public EventDetails(EventDetails eventDetails)
    {
        Timestamp = eventDetails.Timestamp;
        ProfileId = eventDetails.ProfileId;
        ProfileName = eventDetails.ProfileName;
    }
}
