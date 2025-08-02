using MyLibrary.Core.Domain.Common.Models;

namespace MyLibrary.Core.Domain.Common.Abstractions;

public abstract class BaseEntity<TId> : IEntity<TId>
{
    public TId? Id { get; set; }
    public string? EntityType { get; set; }

    public EventDetails? Created { get; set; }

    public EventDetails? LastModified { get; set; }
}
