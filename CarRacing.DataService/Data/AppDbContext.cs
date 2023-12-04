using CarRacing.Entities.DbSet;
using Microsoft.EntityFrameworkCore;

namespace CarRacing.DataService.Data;

public class AppDbContext:DbContext
{
    public virtual DbSet<Driver> Drivers{ get; set; }
    public virtual DbSet<Achievement> Achievements{ get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // specified relationship between the entities
        modelBuilder.Entity<Achievement>(en =>
        {
            en.HasOne(d => d.Driver)
                .WithMany(a => a.Achievements)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Achievements_Driver");
        });
    }
}