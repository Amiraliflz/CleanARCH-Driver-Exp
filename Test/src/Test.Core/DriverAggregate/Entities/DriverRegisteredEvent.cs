using System;
using Test.Core.Common;

namespace Test.Core.DriverAggregate.Entities;

public record DriverRegisteredEvent(Guid DriverId, string Name, string PhoneNumber, DateTime DateOfBirth) : DomainEvent;