using Domain.Entities.SPB;

namespace Domain.Entities
{
    public class Deposit
    {
        public Origin Origin { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
