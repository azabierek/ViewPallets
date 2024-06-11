using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Application.PalletDTOs;
using ViewPallets.Domain.Interfaces;

namespace ViewPallets.Application.PalletCQRS.Queries.GetPalletInformations
{
    public class GetPalletInformationsQueryHandler : IRequestHandler<GetPalletInformationsQuery, PalletDto>
    {
        private readonly IPalletRepository _repository;
        private readonly IMapper _mapper;
        public GetPalletInformationsQueryHandler(IPalletRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PalletDto> Handle(GetPalletInformationsQuery request, CancellationToken cancellationToken)
        {
            var pallet = await _repository.FindPalletDetails(request.palletNumberMediatR!);
            var palletDto = _mapper.Map<PalletDto>(pallet);

            return palletDto;
        }
    }
}
