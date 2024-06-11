using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Application.PalletDTOs;
using ViewPallets.Domain.Entities;
using ViewPallets.Domain.Interfaces;

namespace ViewPallets.Application.PalletCQRS.Queries.GetPalletInformations
{
    public class GetPalletInformationsQuery : PalletDto, IRequest<PalletDto>
    {
        public string palletNumberMediatR { get; set; }
    }
}
