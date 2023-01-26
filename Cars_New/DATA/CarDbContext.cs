using Cars_New.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars_New.DATA
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Basket> baskets { get; set; }
    }
}
