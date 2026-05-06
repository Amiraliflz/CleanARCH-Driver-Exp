namespace Test.Core.DriverAggregate.Events
{
    public record BankAccountChangedEvent(Guid DriverId, string NewBankAccount) : DomainEvent;
}