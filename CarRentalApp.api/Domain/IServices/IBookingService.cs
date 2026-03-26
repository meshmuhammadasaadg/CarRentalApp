using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.IRepositories;
using CarRentalApp.api.Infrastructure.DTOs.Booking;

namespace CarRentalApp.api.Domain.IServices;

public interface IBookingService : IGenericRepository<Booking>
{
    Task AddAsync(BookingCreateDto request); 
}
