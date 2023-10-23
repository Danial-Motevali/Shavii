using Microsoft.EntityFrameworkCore;
using Shavii.Entites;

namespace Shavii.Data.Ef
{
    public class ShaviiDbContext : DbContext
    {
        public ShaviiDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(option =>
            {
                option.HasOne(x => x.Buyer)
                        .WithMany(x => x.Addresses)
                        .HasForeignKey(x => x.BuyerId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
