namespace Entities;

public class EntityBase
{
    public Guid Id { get; set; }

    public bool State { get; set; } = true;

    public DateTime DateRegistration { get; set; } = DateTime.Now;

    public DateTime DateUpdate { get; set; } = DateTime.Now;
}