using CarRentalApp.api.Domain.Entities;
using CarRentalApp.api.Domain.Enums;

namespace CarRentalApp.api.Infrastructure.ViewModels.Booking;

public class BookingCreateViewModel
{
    public string BookingNumber { get; set; } = string.Empty;
    public int CustomerId { get; set; }
    public int CarId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal DepositRequired { get; set; }
    public string? Notes { get; set; }
}
