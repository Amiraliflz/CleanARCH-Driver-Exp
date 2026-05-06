namespace Test.Core.DriverAggregate.Entities
{
    public class Driver
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string LicenseNumber { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public BankAccount BankAccount { get; private set; } 
        public Vehicle Vehicle { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private Driver() { }
        public Driver(string name, string phoneNumber, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            CreatedAt = DateTime.UtcNow;
        }
        public static Driver Create(string name, string phoneNumber, string licenseNumber, DateTime dateOfBirth, BankAccount bankAccount, Vehicle vehicle)
        {
            return new Driver
            {
                Id = Guid.NewGuid(),
                Name = name,
                PhoneNumber = phoneNumber,
                LicenseNumber = licenseNumber,
                DateOfBirth = dateOfBirth,
                BankAccount = bankAccount,
                Vehicle = vehicle,
                CreatedAt = DateTime.UtcNow
                RegisterDomainEvent(new DriverRegisteredEvent(Id, name, phoneNumber, dateOfBirth));
            };
        }
        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
            RegisterDomainEvent(new PhoneNumberChangedEvent(Id, newPhoneNumber));
        }
        public void UpdateVehicle(Vehicle newVehicle)
        {
            Vehicle = newVehicle;
            RegisterDomainEvent(new VehicleChangedEvent(Id, newVehicle));
        }
        public void UpdateBankAccount(BankAccount newBankAccount)
        {
            BankAccount = newBankAccount;
            RegisterDomainEvent(new BankAccountChangedEvent(Id, newBankAccount));
        }
        public void SubmitLicense(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
            RegisterDomainEvent(new LicenseSubmittedEvent(Id, licenseNumber));
        }
        public void SubmitVehicle(Vehicle vehicle)
        {
            Vehicle = vehicle;
            RegisterDomainEvent(new VehicleSubmittedEvent(Id, vehicle));
        }
        public void UploadVehiclePhotos(string[] photoUrls)
        {
            // For simplicity, just raise event
            RegisterDomainEvent(new VehiclePhotosUploadedEvent(Id, photoUrls));
        }
    }
} 