using CarRentalApp.api.Domain.IFacades;
using CarRentalApp.api.Infrastructure.DTOs.Booking;
using CarRentalApp.api.Infrastructure.ViewModels.Booking;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController(IBookingFacade bookingFacade) : ControllerBase
{
    private readonly IBookingFacade _bookingFacade = bookingFacade;

    public async Task<bool> Add([FromBody] BookingCreateViewModel request)
    {
        //var car = await _carService.GetByIdAsync(request.CarId);
        _bookingFacade.Add(new BookingCreateDto
        {
            BookingNumber = request.BookingNumber,
            CarId = request.CarId
        });

        return true;
    }
}
