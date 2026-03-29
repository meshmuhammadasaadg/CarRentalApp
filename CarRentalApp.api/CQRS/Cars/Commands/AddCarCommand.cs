using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.IRepositories;
using MediatR;

namespace CarRentalApp.api.CQRS.Cars.Command;

public record AddCarCommand(string PlateNumber, string Model) : IRequest<bool>;

public class AddCarCommandHandler(IGenericRepository<Car> carRepository) : IRequestHandler<AddCarCommand, bool>
{
    private readonly IGenericRepository<Car> _carRepository = carRepository;

    public Task<bool> Handle(AddCarCommand request, CancellationToken cancellationToken)
    {
        _carRepository.Add(new Car
        {
            PlateNumber = request.PlateNumber,
            Model = request.Model
        });

        return Task.FromResult(true);
    }
}
