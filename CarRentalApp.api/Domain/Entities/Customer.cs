namespace CarRentalApp.api.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string DriverLicenseNumber { get; set; } = string.Empty;
    public DateOnly? DriverLicenseExpiry { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public virtual ICollection<Booking> Bookings { get; set; } = [];
}
