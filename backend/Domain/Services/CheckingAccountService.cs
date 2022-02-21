using Domain.Entities.SPB;
using Domain.Services.Interfaces;

namespace Domain.Services
{
    public class CheckingAccountService : ICheckingAccountService
    {
        public readonly IUserService _userService;
        
        public CheckingAccountService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task ProcessDeposit(SpbEvent spbEvent)
        {
            var user = await _userService.GetByAccountAsync(
                spbEvent.Target.Bank, spbEvent.Target.Branch, spbEvent.Target.Account);

            if (user is null || user.Cpf != spbEvent.Origin.Cpf)
            {
                throw new Exception("Account not found or CPF source is different from destination");
            }

            user.CheckingAccount.AddDeposit(spbEvent.Origin, spbEvent.Amount);
        }
    }
}
