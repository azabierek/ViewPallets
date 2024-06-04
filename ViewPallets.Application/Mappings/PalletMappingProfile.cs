using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Application.PalletDTOs;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Application.Mappings
{
    //using automapper for security reasons
    public class PalletMappingProfile : Profile
    {
        public PalletMappingProfile()
        {
            CreateMap<Details, DetailsDto>();
            CreateMap<Pallet?, PalletDto?>();
            CreateMap<PalletDto?, Pallet?>();
        }
    }
}
