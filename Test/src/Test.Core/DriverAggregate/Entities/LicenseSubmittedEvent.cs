using System;
using Test.Core.Common;

namespace Test.Core.DriverAggregate.Entities;

public record LicenseSubmittedEvent(Guid DriverId, string LicenseNumber) : DomainEvent;