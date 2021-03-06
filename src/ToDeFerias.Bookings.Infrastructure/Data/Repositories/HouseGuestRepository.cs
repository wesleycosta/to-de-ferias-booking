using ToDeFerias.Bookings.Core.Data;
using ToDeFerias.Bookings.Domain.Aggregates.HouseGuestAggregate;
using ToDeFerias.Bookings.Infrastructure.Context;
using ToDeFerias.Bookings.Infrastructure.Repositories;

namespace ToDeFerias.Bookings.Infrastructure.Data.Repositories;

internal sealed class HouseGuestRepository : RepositoryBase<HouseGuest>, IHouseGuestRepository
{
    public HouseGuestRepository(BookingContext context,
                                IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}
