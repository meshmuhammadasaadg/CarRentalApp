using CarRentalApp.api.Domain.IFacades;
using CarRentalApp.api.Domain.IServices;
using CarRentalApp.api.Infrastructure.DTOs.Booking;

namespace CarRentalApp.api.Infrastructure.Facades;

public class BookingFacade(IBookingService bookingService,ICarService carService) : IBookingFacade
{
    private readonly IBookingService _bookingService = bookingService;
    private readonly ICarService _carService = carService;

    public void Add(BookingCreateDto Request)
    {
        throw new NotImplementedException();
    }
}
