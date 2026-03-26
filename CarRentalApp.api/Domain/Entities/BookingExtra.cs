using CarRentalApp.api.Domain.Enums;

namespace CarRentalApp.api.Domain.Entities;

public class BookingExtra
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public BookingExtraType Type { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public virtual Booking Booking { get; set; } = null!;
}
