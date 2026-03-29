using CarRentalApp.api.Domain.Enums;

namespace CarRentalApp.api.Infrastructure.DTOs.Cars;

public record CarCreateRequest(
    int Id,
    string PlateNumber,
    string Model,
    int Year,
    CarStatus Status);

