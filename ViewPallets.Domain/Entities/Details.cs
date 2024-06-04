namespace ViewPallets.Domain.Entities
{
    public class Details
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = default!;
        public int Quantity { get; set; } = default!;
        public Pallet? Pallet { get; set; }

    }
}
