using Dawn;
using Domain.Entities.SPB;
using Domain.Services.Interfaces;

namespace Domain.Services
{
    public class SpbService : ISpbService
    {
        private readonly ICheckingAccountService _checkingAccountService;

        public SpbService(ICheckingAccountService checkingAccountService)
        {
            _checkingAccountService = checkingAccountService;
        }

        public async Task ProcessEventReceivedAsync(SpbEvent spbEvent)
        {
            Guard.Argument(spbEvent.Amount, nameof(spbEvent.Amount)).NotNegative().NotZero();

            switch (spbEvent.Event)
            {
                case Constants.TRANSFER_EVENT:
                    await _checkingAccountService.ProcessDepositAsync(spbEvent);
                    break;

                default:
                    throw new Exception("Invalid event name");
            }
        }
    }
}
