using CarRentalApp.api.Infrastructure.DTOs.Booking;

namespace CarRentalApp.api.Domain.IFacades; 

public interface IBookingFacade
{
    void Add(BookingCreateDto Request); 
}
