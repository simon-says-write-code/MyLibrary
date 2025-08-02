using MyLibrary.Core.Domain.Common.Models;

namespace MyLibrary.Core.Domain.Common.Abstractions;

/// <summary>
/// Base abstraction for DTOs that exposed to API consumers.
/// </summary>
/// <typeparam name="TId">The type of unique identifier.</typeparam>
public abstract record BaseContract<TId>
{
    /// <summary>
    /// Get the unique identifier.
    /// </summary>
    public TId? Id { get; private set; }

    /// <summary>
    /// Details of when the resource was created.
    /// </summary>
    public EventDetails? Created { get; private set; }

    /// <summary>
    /// Details of when the resource was last modified.
    /// </summary>
    public EventDetails? LastModified { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseContract{TId}"/> class.
    /// </summary>
    public BaseContract()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseContract{TId}"/> class with a specified unique identifier.
    /// </summary>
    /// <param name="id">The supplied id.</param>
    public BaseContract(TId id)
    {
        Id = id;
    }

    /// <summary>
    /// Set the unique identifier.
    /// </summary>
    /// <param name="id">The supplied id.</param>
    public void SetId(TId id)
    {
        if (Id is not null)
            throw new ArgumentException("Id is already set.", nameof(id));

        Id = id;
    }

    /// <summary>
    /// Set the created information for the resource, including the timestamp and profile details.
    /// </summary>
    /// <param name="eventDetails">The event details.</param>
    /// <exception cref="ArgumentException">Thrown if the created info is already set.</exception>
    public void SetCreatedInfo(EventDetails eventDetails)
    {
        if (Created is not null)
            throw new ArgumentException("Created information is already set.", nameof(eventDetails));

        Created = new EventDetails(eventDetails);
        LastModified = Created;
    }

    /// <summary>
    /// Set the last modified information for the resource, including the timestamp and profile details.
    /// </summary>
    /// <param name="eventDetails">The event details.</param>
    /// <exception cref="ArgumentException">Thrown if the given details has a timestamp earlier than the current timestamp.</exception>
    public void SetLastModifiedInfo(EventDetails eventDetails)
    {
        if (LastModified?.Timestamp >= eventDetails.Timestamp)
            throw new ArgumentException("Last modified information must have a later dateTime than the current last modified time.", nameof(eventDetails));

        LastModified = new EventDetails(eventDetails);
    }
}
