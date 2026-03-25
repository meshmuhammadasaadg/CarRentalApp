namespace CarRentalApp.api.Domain.Enums;

public enum DepositStatus
{
    /// </summary>
    None = 0,

    /// <summary>
    /// Deposit payment is pending
    /// </summary>
    Pending = 1,

    /// <summary>
    /// Deposit has been authorized but not yet captured
    /// </summary>
    Authorized = 2,

    /// <summary>
    /// Deposit has been captured/charged
    /// </summary>
    Captured = 3,

    /// <summary>
    /// Deposit has been refunded
    /// </summary>
    Refunded = 4,

    /// <summary>
    /// Deposit payment failed
    /// </summary>
    Failed = 5
}
