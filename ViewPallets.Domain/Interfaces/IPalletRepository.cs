using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Domain.Interfaces
{
    public interface IPalletRepository
    {
        Task<Pallet?> FindPalletDetails(string palletNumber);
    }
}
