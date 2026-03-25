namespace CarRentalApp.api.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal DailyRate { get; set; }
    public bool IsActive { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = [];
}
