using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.UpdateVehicleDetails;

/// <summary>
/// Update vehicle details.
/// </summary>
public record UpdateVehicleDetailsCommand(Guid DriverId, Vehicle NewVehicle) : ICommand<Result>;