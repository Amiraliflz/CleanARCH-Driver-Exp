using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.SubmitVehicleRegistration;

/// <summary>
/// Submit vehicle registration documents.
/// </summary>
public record SubmitVehicleRegistrationCommand(Guid DriverId, Vehicle Vehicle) : ICommand<Result>;