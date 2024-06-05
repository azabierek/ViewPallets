namespace ViewPallets.Domain.Entities
{
    public class Pallet
    {
        public int Id { get; set; }
        public string? PalletNumber { get; private set; }
        public int Height { get; set; } = default!;
        public int Width { get; set; } = default!;
        public int Length { get; set; } = default!;
        public int Weight { get; set; } = default!;
        public string CustomerName { get; set; } = default!;
        public string ProjectName { get; set; } = default!;
        public string ProjectId { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Details>? Details { get; set; }


        private void SetPalletNumber() => PalletNumber = "PL" + Guid.NewGuid();
        
        public Pallet() => SetPalletNumber();
    }
}