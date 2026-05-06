using System;
using Test.Core.Common;
using Test.Core.DriverAggregate.Entities;

namespace Test.Core.DriverAggregate.Entities;

public record VehicleSubmittedEvent(Guid DriverId, Vehicle Vehicle) : DomainEvent;