using System;
using Test.Core.Common;

namespace Test.Core.DriverAggregate.Entities;

public record PhoneNumberChangedEvent(Guid DriverId, string NewPhoneNumber) : IDomainEvent;
