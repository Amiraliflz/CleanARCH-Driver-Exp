public record Vehicle
{
    public string Make { get; init; }
    public string Model { get; init; }
    public int Year { get; init; }
    public string LicensePlate { get; init; }
    public IreadOnlyList<string> Photos { get; init; } = new List<string>();

    public Vehicle(string make, string model, int year, string licensePlate, IReadOnlyList<string> photos)
    {
        Make = make;
        Model = model;
        Year = year;
        LicensePlate = licensePlate;
        Photos = photos;
    }
}
   