namespace Test.UseCases.Drivers.UploadLicense;

/// <summary>
/// Upload driver's license for verification.
/// </summary>
public record UploadLicenseCommand(Guid DriverId, string LicenseNumber) : ICommand<Result> ;