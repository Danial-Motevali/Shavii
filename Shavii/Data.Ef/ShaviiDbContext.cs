using Microsoft.EntityFrameworkCore;

namespace Shavii.Data.Ef
{
    public class ShaviiDbContext : DbContext
    {
        public DbSet<> MyProperty { get; set; }
    }
}
