using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.UploadVehiclePhotos;

public class UploadVehiclePhotosHandler(IRepository<Driver> _repository)
  : ICommandHandler<UploadVehiclePhotosCommand, Result>
{
  public async ValueTask<Result> Handle(UploadVehiclePhotosCommand command,
    CancellationToken cancellationToken)
  {
    var driver = await _repository.GetByIdAsync(command.DriverId, cancellationToken);
    if (driver is null)
    {
      return Result.NotFound();
    }

    driver.UploadVehiclePhotos(command.PhotoUrls);
    await _repository.UpdateAsync(driver, cancellationToken);

    return Result.Success();
  }
}