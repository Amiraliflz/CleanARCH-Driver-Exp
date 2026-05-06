using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.SubmitVehicleRegistration;

public class SubmitVehicleRegistrationHandler(IRepository<Driver> _repository)
  : ICommandHandler<SubmitVehicleRegistrationCommand, Result>
{
  public async ValueTask<Result> Handle(SubmitVehicleRegistrationCommand command,
    CancellationToken cancellationToken)
  {
    var driver = await _repository.GetByIdAsync(command.DriverId, cancellationToken);
    if (driver is null)
    {
      return Result.NotFound();
    }

    driver.SubmitVehicle(command.Vehicle);
    await _repository.UpdateAsync(driver, cancellationToken);

    return Result.Success();
  }
}