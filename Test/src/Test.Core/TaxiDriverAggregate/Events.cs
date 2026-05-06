namespace Test.Core.TaxiDriverAggregate
{
    public class TaxiDriverRegisteredEvent
    {
        public Guid DriverId { get; set; }
        public string Email { get; set; }

        public TaxiDriverRegisteredEvent(Guid driverId, string email)
        {
            DriverId = driverId;
            Email = email;
        }
    }
}