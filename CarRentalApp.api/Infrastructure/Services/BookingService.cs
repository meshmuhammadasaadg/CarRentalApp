using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.IServices;
using CarRentalApp.api.Infrastructure.DTOs.Booking;
using CarRentalApp.api.Infrastructure.Persistence;
using CarRentalApp.api.Infrastructure.Repositories;

namespace CarRentalApp.api.Infrastructure.Services;

public class BookingService(ApplicationDbContext context) : GenericRepository<Booking>(context), IBookingService
{
    private readonly ApplicationDbContext _context = context;

    public async Task AddAsync(BookingCreateDto request)
    {
        throw new NotImplementedException();
    }
}
