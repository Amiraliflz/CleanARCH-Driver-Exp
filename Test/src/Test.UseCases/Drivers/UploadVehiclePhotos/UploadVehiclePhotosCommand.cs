namespace Test.UseCases.Drivers.UploadVehiclePhotos;

/// <summary>
/// Upload vehicle photos.
/// </summary>
public record UploadVehiclePhotosCommand(Guid DriverId, string[] PhotoUrls) : ICommand<Result>;