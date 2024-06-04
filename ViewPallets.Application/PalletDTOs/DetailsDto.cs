using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewPallets.Application.PalletDTOs
{
    public class DetailsDto
    {
        public string ItemName { get; set; } = default!;
        public int Quantity { get; set; } = default!;
    }
}
