using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.Enums;
using CarRentalApp.api.Domain.IRepositories;
using CarRentalApp.api.Infrastructure.DTOs.Cars;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.api.CQRS.Cars.Queries;

public record GetAvailableCarsQuery() : IRequest<IEnumerable<CarResponse>>;

public class GetAvailableCarsQueryHandler(IGenericRepository<Car> carRepository) : IRequestHandler<GetAvailableCarsQuery, IEnumerable<CarResponse>>
{
    private readonly IGenericRepository<Car> _carRepository = carRepository;

    public async Task<IEnumerable<CarResponse>> Handle(GetAvailableCarsQuery request, CancellationToken cancellationToken) =>
        await _carRepository.GetAll()
            .Where(c => c.Status == CarStatus.Available)
            .Select(x => new CarResponse(
                x.Id,
                x.Year,
                x.Model,
                x.PlateNumber
                ))
            .ToListAsync(cancellationToken);
}