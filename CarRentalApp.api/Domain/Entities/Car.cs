namespace CarRentalApp.api.Domain.Entities;

public class Car
{
    public int Id { get; set; }
    public string PlateNumber { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public CarStatus Status { get; set; } = CarStatus.Available;
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
