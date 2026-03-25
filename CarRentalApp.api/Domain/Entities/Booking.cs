namespace CarRentalApp.api.Domain.Entities;

public class Booking
{
    public int Id { get; set; }
    public string BookingNumber { get; set; } = string.Empty;
    public int CustomerId { get; set; }
    public int CarId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public BookingStatus Status { get; set; } = BookingStatus.Pending;
    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal Total { get; set; }
    public decimal DepositRequired { get; set; }
    public DepositStatus DepositStatus { get; set; } = DepositStatus.None;
    public string? Notes { get; set; }
    public virtual Customer Customer { get; set; } = null!;
    public virtual Car Car { get; set; } = null!;
    public virtual ICollection<BookingExtra> BookingExtras { get; set; } = new List<BookingExtra>();
}
