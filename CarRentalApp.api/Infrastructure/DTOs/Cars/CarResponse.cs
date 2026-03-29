namespace CarRentalApp.api.Infrastructure.DTOs.Cars;

public record CarResponse(
    int Id,
    int Year,
    string PlateNumber,
    string Model);
