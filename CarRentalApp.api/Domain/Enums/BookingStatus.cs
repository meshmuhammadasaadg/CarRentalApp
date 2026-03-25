namespace CarRentalApp.api.Domain.Enums;

public enum BookingStatus
{
    /// <summary>
    /// Booking is pending confirmation
    /// </summary>
    Pending = 0,

    /// <summary>
    /// Booking has been confirmed
    /// </summary>
    Confirmed = 1,

    /// <summary>
    /// Booking has been cancelled
    /// </summary>
    Cancelled = 2,

    /// <summary>
    /// Booking is currently active (car is rented)
    /// </summary>
    Active = 3,

    /// <summary>
    /// Booking has been completed
    /// </summary>
    Completed = 4
}
