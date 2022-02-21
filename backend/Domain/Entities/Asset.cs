namespace Domain.Entities
{
    public class Asset
    {
        public string Symbol { get; set; }
        public long Amount { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
