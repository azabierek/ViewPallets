using Microsoft.EntityFrameworkCore;
using ViewPallets.Domain.Entities;
using ViewPallets.Domain.Interfaces;
using ViewPallets.Infrastructure.Persistence;

namespace ViewPallets.Infrastructure.Repositories
{
    internal class PalletRepository : IPalletRepository
    {
        //DI
        private readonly PalletDbContext _dbContext;
        public PalletRepository(PalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Pallet?> FindPalletDetails(string palletNumber) => await _dbContext.Pallet.Include(x=>x.Details).FirstOrDefaultAsync(x => x.PalletNumber == palletNumber);
         
    }
}
