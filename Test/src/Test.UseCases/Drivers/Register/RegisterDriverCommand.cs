using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.Register;

/// <summary>
/// Register a new Driver with personal information.
/// </summary>
public record RegisterDriverCommand(string Name, string PhoneNumber, DateTime DateOfBirth) : ICommand<Result<Guid>>;