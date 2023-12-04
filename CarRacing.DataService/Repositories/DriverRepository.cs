using CarRacing.DataService.Data;
using CarRacing.DataService.Repositories.Interfaces;
using CarRacing.Entities.DbSet;
using Microsoft.Extensions.Logging;

namespace CarRacing.DataService.Repositories;

public class DriverRepository: GenericRepository<Driver>, IDriverRepository
{
    public DriverRepository(ILogger logger, AppDbContext context) : base(logger, context)
    {
    }

    public override async Task<IEnumerable<Driver>> All()
    {
        
    }
}