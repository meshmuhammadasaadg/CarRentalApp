namespace CarRentalApp.api.Infrastructure.ViewModels.Cars;

public class CarViewModel
{
    public int Id { get; set; }
    public string PlateNumber { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    //public int Year { get; set; }
}
