namespace CarRentalApp.api.Domain.Enums;

public enum CarStatus
{
    /// </summary>
    Available = 0,

    /// <summary>
    /// Car is currently rented out
    /// </summary>
    Rented = 1,

    /// <summary>
    /// Car is undergoing maintenance
    /// </summary>
    Maintenance = 2,

    /// <summary>
    /// Car is inactive and not available for rental
    /// </summary>
    Inactive = 3
}
