using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.UpdateVehicleDetails;

public class UpdateVehicleDetailsHandler(IRepository<Driver> _repository)
  : ICommandHandler<UpdateVehicleDetailsCommand, Result>
{
  public async ValueTask<Result> Handle(UpdateVehicleDetailsCommand command,
    CancellationToken cancellationToken)
  {
    var driver = await _repository.GetByIdAsync(command.DriverId, cancellationToken);
    if (driver is null)
    {
      return Result.NotFound();
    }

    driver.UpdateVehicle(command.NewVehicle);
    await _repository.UpdateAsync(driver, cancellationToken);

    return Result.Success();
  }
}