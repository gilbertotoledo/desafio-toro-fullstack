namespace Domain.Entities.SPB
{
    public class SpbEvent
    {
        public string Event { get; set; }                
        public Target Target { get; set; }
        public Origin Origin { get; set; }
        public decimal Amount { get; set; }
    }
}
