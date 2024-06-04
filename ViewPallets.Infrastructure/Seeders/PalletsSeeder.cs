using ViewPallets.Domain.Entities;
using ViewPallets.Infrastructure.Persistence;

namespace ViewPallets.Infrastructure.Seeders
{
    public class PalletsSeeder
    {
        private readonly PalletDbContext _dbContext;
        public PalletsSeeder(PalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task SeedDatabase()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Pallet.Any())
                {
                    //Creating two pallets with details on.
                    await _dbContext.Pallet.AddRangeAsync(DataCreator.CreatePalletsRange());
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
