namespace CarRentalApp.api.Infrastructure.DTOs.Cars;

public record CarCreateRequest(
    string PlateNumber,
    string Model,
    int Year
    );

