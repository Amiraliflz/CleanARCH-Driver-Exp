using System;
using Test.Core.Common; 
namespace Test.Core.DriverAggregate.Entities
{
    public record VehicleChangedEvent(Guid DriverId, Vehicle NewVehicle) : DomainEvent;
}