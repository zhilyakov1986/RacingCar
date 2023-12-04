namespace CarRacing.DataService.Repositories.Interfaces;

public interface IUnitOfWork
{
    IDriverRepository Drivers { get; }
    IAchievementsRepository Achievement { get; }

    Task CompleteAsync();
}