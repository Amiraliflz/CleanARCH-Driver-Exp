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
            };
        }
        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }
    }
} 