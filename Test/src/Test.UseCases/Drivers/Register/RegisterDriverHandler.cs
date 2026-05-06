using Test.Core.DriverAggregate.Entities;

namespace Test.UseCases.Drivers.Register;

public class RegisterDriverHandler(IRepository<Driver> _repository)
  : ICommandHandler<RegisterDriverCommand, Result<Guid>>
{
  public async ValueTask<Result<Guid>> Handle(RegisterDriverCommand command,
    CancellationToken cancellationToken)
  {
    var newDriver = new Driver(command.Name, command.PhoneNumber, command.DateOfBirth);
    var createdItem = await _repository.AddAsync(newDriver, cancellationToken);

    return createdItem.Id;
  }
}