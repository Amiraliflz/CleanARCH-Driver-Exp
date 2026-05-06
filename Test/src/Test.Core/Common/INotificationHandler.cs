using System.Threading;
using System.Threading.Tasks;

namespace Test.Core.Common;

public interface INotificationHandler<in TNotification>
{
    ValueTask Handle(TNotification notification, CancellationToken cancellationToken);
}
