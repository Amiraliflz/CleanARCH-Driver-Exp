namespace Test.Core.DriverAggregate.Handlers;
public class BankAccountUpdateEventHandler
    : INotificationHandler<BankAccountChangedEvent>
{
    public async Task Handle(BankAccountChangedEvent notification, CancellationToken cancellationToken)
    {
        // Handle bank account change event
    }
}