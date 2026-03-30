using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.IRepositories;
using MediatR;

namespace CarRentalApp.api.CQRS.Cars.Command;

public record AddCarCommand(
    string PlateNumber,
    string Model,
    int Year
    ) : IRequest<bool>;

public class AddCarCommandHandler(IGenericRepository<Car> carRepository) : IRequestHandler<AddCarCommand, bool>
{
    private readonly IGenericRepository<Car> _carRepository = carRepository;

    public async Task<bool> Handle(AddCarCommand request, CancellationToken cancellationToken)
    {
        _carRepository.Add(new Car
        {
            PlateNumber = request.PlateNumber,
            Model = request.Model,
            Year = request.Year,
            CategoryId = 1,
            Status = Domain.Enums.CarStatus.Available
        });

        var isAdded = await _carRepository.SaveChangedAsync();

        if (isAdded == 0)
            return false;

        return true;
    }
}
