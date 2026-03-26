namespace CarRentalApp.api.Infrastructure.DTOs.Cars;

public class CarCreateRequest
{
    public string PlateNumber { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
}
