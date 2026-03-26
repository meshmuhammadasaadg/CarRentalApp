using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.Enums;
using CarRentalApp.api.Domain.IServices;
using CarRentalApp.api.Infrastructure.DTOs.Cars;
using CarRentalApp.api.Infrastructure.Persistence;
using CarRentalApp.api.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.api.Infrastructure.Services;

public class CarService(ApplicationDbContext context) : GenericRepository<Car>(context), ICarService
{
    private readonly ApplicationDbContext _context = context;

    public async Task<IEnumerable<Car>> GetAllCars() => await GetAll().ToListAsync();

    public async Task<IEnumerable<CarResponse>> GetAvailableAsync()
    {
        var cars = await GetByPredicate(c => c.Status == CarStatus.Available)
            .Select(c => new CarResponse
            {
                Id = c.Id,
                PlateNumber = c.PlateNumber,
                Model = c.Model,
                Year = c.Year
            }).ToListAsync();

        return cars;
    }

    public async Task<CarResponse?> GetByIdAsync(int id)
        => await GetAll().Where(c => c.Id == id)
        .Select(x => new CarResponse
        {
            Id = x.Id,
            PlateNumber = x.PlateNumber,
            Model = x.Model,
            Year = x.Year
        })
        .FirstOrDefaultAsync();

    public async Task AddCarAsync(CarCreateRequest request)
    {
        throw new NotImplementedException();
    }
}
