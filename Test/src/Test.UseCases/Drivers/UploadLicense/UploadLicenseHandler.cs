using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.UploadLicense;

public class UploadLicenseHandler(IRepository<Driver> _repository)
  : ICommandHandler<UploadLicenseCommand, Result>
{
  public async ValueTask<Result> Handle(UploadLicenseCommand command,
    CancellationToken cancellationToken)
  {
    var driver = await _repository.GetByIdAsync(command.DriverId, cancellationToken);
    if (driver is null)
    {
      return Result.NotFound();
    }

    driver.SubmitLicense(command.LicenseNumber);
    await _repository.UpdateAsync(driver, cancellationToken);

    return Result.Success();
  }
}