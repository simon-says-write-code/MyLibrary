using MyLibrary.Core.Domain.Common.Models;

namespace MyLibrary.Core.Domain.Common.Abstractions;

public interface IEntity<TId>
{
    /// <summary>
    /// The identifier of the entity.
    /// </summary>
    public TId? Id { get; set; }

    /// <summary>
    /// The type of entity.
    /// </summary>
    public string? EntityType { get; set; }

    /// <summary>
    /// Details of when the entity was created.
    /// </summary>
    public EventDetails? Created { get; set; }

    /// <summary>
    /// Details of when the entity was last modified.
    /// </summary>
    public EventDetails? LastModified { get; set; }
}
