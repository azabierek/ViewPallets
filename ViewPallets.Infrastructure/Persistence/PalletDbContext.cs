using Microsoft.EntityFrameworkCore;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Infrastructure.Persistence
{
    public class PalletDbContext : DbContext
    {
        public PalletDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Pallet> Pallet { get; set; }
        public DbSet<Details> Details { get; set; }

    }
}
