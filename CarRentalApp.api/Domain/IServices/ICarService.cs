using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.IRepositories;
using CarRentalApp.api.Infrastructure.DTOs.Cars;

namespace CarRentalApp.api.Domain.IServices;

public interface ICarService : IGenericRepository<Car>
{
    Task<IEnumerable<Car>> GetAllCars();
    Task<IEnumerable<CarResponse>> GetAvailableAsync();
    Task<CarResponse?> GetByIdAsync(int id);
    Task AddCarAsync(CarCreateRequest request);
}
