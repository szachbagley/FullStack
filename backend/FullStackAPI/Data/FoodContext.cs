using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }

        public DbSet<MarriottFood> Foods { get; set; }
    }
}
