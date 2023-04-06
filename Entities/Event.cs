namespace Entities;

public class Event : EntityBase
{
    public string? Title { get; set; }

    public string? Description { get; set; }
    
    public Guid CategoryId { get; set; } // FK

    public DateTime Date { get; set; }

    public string? StartTime { get; set; }

    public string? City { get; set; }

    public string? Address { get; set; }

    public string? Reference { get; set; }

    public string? RecommendedAudience { get; set; }

    public string? Banner { get; set; }

    public string? DistributionImage { get; set; }
    
    // FK
    public Category Category { get; set; }
}