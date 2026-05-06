namespace Test.Core.DriverAggregate.Handlers;
public class VehicleUpdateEventHandler
    : INotificationHandler<VehicleChangedEvent>
{
    public async Task Handle(VehicleChangedEvent notification, CancellationToken cancellationToken)
    {
        // Handle vehicle change event
    }
}