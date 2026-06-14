namespace GymManagement.Models;

public class Plan
{
    public int Id { get; set; }
    public string  Name { get; set; } = default!;
    public string Descriptiion { get; set; } = default!;
    public int DurationDays { get; set; }
    public decimal Price { get; set; }
    public bool IsAcive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
