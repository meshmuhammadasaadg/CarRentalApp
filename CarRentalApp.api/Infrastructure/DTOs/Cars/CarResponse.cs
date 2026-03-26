namespace CarRentalApp.api.Infrastructure.DTOs.Cars;

public class CarResponse
{
    public int Id { get; set; }
    public string PlateNumber { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
}
