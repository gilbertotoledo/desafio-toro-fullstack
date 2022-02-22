using Domain.Entities.SPB;
using Domain.Services;
using Moq;
using System.Threading.Tasks;

namespace UnitTests.Services.Context
{
    public class SpbServiceContext
    {
        public Mock<ICheckingAccountService> CheckingAccountService;

        public SpbServiceContext()
        {
            CheckingAccountService = new Mock<ICheckingAccountService>();
        }

        public void MockProcessDeposit(SpbEvent spbEvent)
        {
            CheckingAccountService.Setup(p => p.ProcessDepositAsync(It.IsAny<SpbEvent>()))
                .Returns(Task.FromResult(spbEvent));
        }
    }
}
