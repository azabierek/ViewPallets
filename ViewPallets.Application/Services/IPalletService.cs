using ViewPallets.Application.PalletDTOs;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Application.Services
{
    public interface IPalletService
    {
        Task<PalletDto?> FindPalletDetails(string palletNumber);
    }
}