using MassTransit;
using Infrastructure;
 
namespace ProcessCenter.Consumers
{
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        public async Task Consume(ConsumeContext<OrderCreated> context)
        {
 
        }
    }
}