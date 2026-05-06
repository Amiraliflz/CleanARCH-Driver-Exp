using System.ComponentModel;

namespace Test.Core.TaxiDriverAggregate
{
    public class TaxiDriver : EntityBase<TaxiDriver, Guid>, IAggregateRoot
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public License License { get; set; }
        public DriverStatus Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        private readonly List<Vehicle> _vehicles = [];
        public IReadOnlyCollection<Vehicle> Vehicles => _vehicles.AsReadOnly();

        private readonly List<InteCityRouteAuthoirization> _routes = [];
        public IReadOnlyCollection<InteCityRouteAuthoirization> Routes => _routes.AsReadOnly();

        private TaxiDriver() { }

        private TaxiDriver(
            string firstName = Gurad.Against.NullOrWhitespace(FirstName),
            string lastName = Gurad.Against.NullOrWhitespace(LastName),
            string email = Gurad.Against.NullOrWhitespace(Email),
            string phoneNumber = Gurad.Against.NullOrWhitespace(PhoneNumber),
                License license = Gurad.Against.Null(License)
        )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            License = license;
            Status = DriverStatus.Active;
            RegistrationDate = DateTime.Now;
        }

        public static TaxiDriver create(string firstName, string lastName, string email, string phoneNumber, License license)
        {
            var driver = new TaxiDriver
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                License = license,
                Status = DriverStatus.Active,
                RegistrationDate = DateTime.Now
            };
            driver.AddDomainEvent(new TaxiDriverCreatedEvent(driverId, email));
            return driver;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            Guard.Against.Null(vehicle, nameof(vehicle));
            var exists = _vehicles.Where(v => v.LicensePlate == vehicle.LicensePlate).Any();
            if (exists) throw new InvalidOperationException("vehicle with the same plate already exists for this driver.");

            _vehicles.Add(vehicle);
        }
    }
}