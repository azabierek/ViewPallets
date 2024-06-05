using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Application.PalletDTOs
{
    public class PalletDto
    {
        public string? PalletNumber { get; private set; }
        public int Height { get; set; } = default!;
        public int Width { get; set; } = default!;
        public int Length { get; set; } = default!;
        public int Weight { get; set; } = default!;
        public string CustomerName { get; set; } = default!;
        public string ProjectName { get; set; } = default!;
        public string ProjectId { get; set; } = default!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<DetailsDto>? Details { get; set; }
    }
}
