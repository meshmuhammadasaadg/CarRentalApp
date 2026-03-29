using CarRentalApp.api.Infrastructure.DTOs.Cars;
using CarRentalApp.api.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.api.CQRS.Cars.Queries;

public record GetCarByIdQuery(int Id) : IRequest<CarResponse?>;

public class GetCarByIdQueryHandler(ApplicationDbContext context) : IRequestHandler<GetCarByIdQuery, CarResponse?>
{
    private readonly ApplicationDbContext _context = context;

    public async Task<CarResponse?> Handle(GetCarByIdQuery request, CancellationToken cancellationToken) =>
        await _context.Cars.Where(c => c.Id == request.Id)
            .Select(x => new CarResponse(
                x.Id,
                x.Year,
                x.PlateNumber,
                x.Model
                )).FirstOrDefaultAsync(cancellationToken);
}
