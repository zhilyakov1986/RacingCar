namespace CarRacing.Entities.DbSet;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime AddDate { get; set; } = DateTime.UtcNow;
    public DateTime UpdateDate { get; set; } = DateTime.UtcNow;

}