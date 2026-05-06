using System;
using Test.Core.Common;

namespace Test.Core.DriverAggregate.Entities;

public record VehiclePhotosUploadedEvent(Guid DriverId, string[] PhotoUrls) : DomainEvent;