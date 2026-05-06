using System.ComponentModel;
using System.IO.Pipelines;
using System.Windows.Input;
using Test.Core.TaxiDriverAggregate;
namespace Test.UseCases.TaxiDriverAggerate.RegisterTaxiDriver;

public class RegisterTaxiDriverHandler(IRepository<TaxiDriver> _repository) : ICommandHandler<RegiserTaxiDriverCommand, Result<Guid>>
{
    private readonly IRepository<TaxiDriver> _repository;
    public async ValueTask<ReadResult<Guid>> Handle(RegisterTaxiDriverCommand command, CanncelationToken canncelationToken)
    {
        var license = new License(
            command.LicenseNumber,
            command.IssuingCountry,
            command.LicenseExpiryDate);

        if (license.IsExpired())

            return Result.invalid(new ValidationErrr("License is expired")

    );
        var driver = TaxiDriver.Create(
            command.FirstName,
            command.LastName,
            command.Email,
            command.PhoneNumber,
            license
        );
        var created = await _repository.AddAsync(driver, canncelationToken);
        return Result.Success(created.Id);
    }
}