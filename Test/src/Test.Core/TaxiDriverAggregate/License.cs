using System.ComponentModel;

namespace Test.Core.TaxiDriverAggregate
{
    public class License
    {
        public string LicenseNumber { get; set; }
        public string IssuingCountry { get; set; }
        public DateTime ExpiryDate { get; set; }

        public bool IsExpired()
        {
            return ExpiryDate < DateTime.UtcNow;
        }
    }
}