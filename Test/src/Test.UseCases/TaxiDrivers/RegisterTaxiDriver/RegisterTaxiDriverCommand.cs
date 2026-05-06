namespace Test.UseCases.TaxiDrivers.RegisterTaxiDriver
{
    public record RegisterTaxiDriverCommand(

        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber,
        string LicenseNumber,
        string IssuingCountry,
        DateTime LicenseExpiryDate
    ) : ICommand<Result<Guid>>;

}