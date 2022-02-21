using Domain.Entities.SPB;
using Infrastructure.CrossCutting;

namespace Domain.Entities
{
    public class CheckingAccount
    {
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string Account { get; set; }        
        public decimal Amount { get; set; }
        public IList<Deposit> Deposits { get; set; }

        public void AddDeposit(Origin origin, decimal amount)
        {
            Deposits.Add(new Deposit()
            {
                Origin = origin,
                Amount = amount,
            });
            Amount += amount;
        }

        public CheckingAccount() {
            Bank = Constants.BANCK_CODE;
            Branch = Constants.BRANCH_DEFAULT;
            Account = RandomUtils.BuildRandomNumericString(Constants.ACCOUNT_NUMBER_LENGHT);
            Amount = 0;
            Deposits = new List<Deposit>();
        }
    }
}
