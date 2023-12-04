using CarRacing.Entities.DbSet;

namespace CarRacing.DataService.Repositories.Interfaces;

public interface IAchievementsRepository : IGenericRepository<Achievement>
{
    Task<Achievement> GetDriverAchievementAsync(Guid driverId);
}