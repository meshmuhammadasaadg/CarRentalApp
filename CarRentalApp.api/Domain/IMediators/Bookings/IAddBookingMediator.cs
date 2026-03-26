using CarRentalApp.api.Infrastructure.DTOs.Booking;

namespace CarRentalApp.api.Domain.IMediators.Bookings;

public interface IAddBookingMediator
{
    void Add(BookingCreateDto Request);

}
