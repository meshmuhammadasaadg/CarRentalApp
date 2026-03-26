using CarRentalApp.api.Domain.IMediators.Bookings;
using CarRentalApp.api.Domain.IServices;
using CarRentalApp.api.Infrastructure.DTOs.Booking;

namespace CarRentalApp.api.Infrastructure.Mediators.Bookings;

public class AddBookingMediator(IBookingService bookingService, ICarService carService) : IAddBookingMediator
{
    private readonly IBookingService _bookingService = bookingService;
    private readonly ICarService _carService = carService;

    public void Add(BookingCreateDto Request)
    {
        throw new NotImplementedException();
    }
}
