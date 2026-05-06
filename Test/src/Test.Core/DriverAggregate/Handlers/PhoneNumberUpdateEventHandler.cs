namespace Test.Core.DriverAggregate.Handlers;
public class PhoneNumberUpdateEventHandler
    : INotificationHandler<PhoneNumberChangedEvent>
{
    public async Task Handle(PhoneNumberChangedEvent notification, CancellationToken cancellationToken)
    {
        // Handle phone number change event
    }
}
