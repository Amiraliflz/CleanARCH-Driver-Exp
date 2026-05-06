using System.ComponentModel;

namespace Test.Core.TaxiDriverAggregate
{
    public class Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public License License { get; set; }
        public DriverStatus Status { get; set; }
    }
}