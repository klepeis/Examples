using Microsoft.EntityFrameworkCore;

namespace MappingBetweenLayers.Infrastructure.DbContexts
{
    public class SampleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
