using System;

namespace Test.Core.Common;

public interface IDomainEvent
{
    // A unique identifier for this specific occurrence of the event
    Guid EventId { get; }

    // The exact date and time the event happened
    DateTime OccurredOn { get; }
}

public abstract class DomainEvent : IDomainEvent
{
    public Guid EventId { get; } = Guid.NewGuid();
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}