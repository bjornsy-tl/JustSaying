using JustSaying.Messaging.MessageHandling;

namespace JustSaying.IntegrationTests.TestHandlers;

public class OrderDispatcher : IHandlerAsync<OrderPlaced>
{
    public OrderDispatcher(Future<OrderPlaced> future)
    {
        Future = future;
    }

    public async Task<bool> Handle(OrderPlaced message)
    {
        await Future.Complete(message);
        return true;
    }

    public Future<OrderPlaced> Future { get; }
}