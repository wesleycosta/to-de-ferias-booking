using MediatR;

namespace ToDeFerias.Bookings.Domain.Events.Bookings;

public sealed class RegisteredBookingHandler : INotificationHandler<RegisteredBookingEvent>
{
    public async Task Handle(RegisteredBookingEvent @event, CancellationToken cancellationToken)
    {
        var random = new Random().Next(0, 100);
        await Task.Delay(random);
    }
}
