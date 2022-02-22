using Domain.Entities.SPB;

namespace Domain.Services
{
    public interface ICheckingAccountService
    {
        Task ProcessDepositAsync(SpbEvent spbEvent);
    }
}
