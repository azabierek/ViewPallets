using AutoMapper;
using ViewPallets.Application.PalletDTOs;
using ViewPallets.Domain.Entities;
using ViewPallets.Domain.Interfaces;

namespace ViewPallets.Application.Services
{
    public class PalletService : IPalletService
    {
        //DI
        private readonly IPalletRepository _palletRepository;
        private readonly IMapper _mapper;

        public PalletService(IPalletRepository palletRepository, IMapper mapper)
        {
            _palletRepository = palletRepository;
            _mapper = mapper;
        }

        public async Task<PalletDto?> FindPalletDetails(string palletNumber)
        {
            var pallet = await _palletRepository.FindPalletDetails(palletNumber);
            var palletDto = _mapper.Map<PalletDto>(pallet);

            return palletDto;
        }
    }
}
