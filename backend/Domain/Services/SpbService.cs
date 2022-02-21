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

        public async Task ProcessEventReceived(SpbEvent spbEvent)
        {
            switch (spbEvent.Event)
            {
                case Constants.TRANSFER_EVENT:
                    await _checkingAccountService.ProcessDeposit(spbEvent);
                    break;

                default:
                    throw new Exception("Event invalid");
            }
        }
    }
}
