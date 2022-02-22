using Domain.Entities.SPB;
using Domain.Services;
using Moq;
using System;
using UnitTests.Services.Context;
using UnitTests.Services.Fake;
using Xunit;

namespace UnitTests.Services
{
    public class SpbServiceTests
    {
        private readonly SpbService _spbService;
        private readonly SpbServiceContext _spbServiceContext;

        public SpbServiceTests()
        {
            _spbServiceContext = new SpbServiceContext();
            _spbService = new SpbService(_spbServiceContext.CheckingAccountService.Object);
        }

        [Fact]
        public async void ProcessEventReceived_ShouldSucceedAsync()
        {
            //Arrange
            _spbServiceContext.MockProcessDeposit(FakeSpbEvent.SpbEventValid);

            //Act
            await _spbService.ProcessEventReceivedAsync(FakeSpbEvent.SpbEventValid);

            //Assert
            _spbServiceContext.CheckingAccountService.Verify(p => p.ProcessDepositAsync(It.IsAny<SpbEvent>()), Times.Once);
        }

        [Fact]
        public async void ProcessEventReceived_WithInvalidEventName_ShouldThrowExceptionAsync()
        {
            //Arrange
            _spbServiceContext.MockProcessDeposit(FakeSpbEvent.SpbEventValid);

            //Act & Assert
            await Assert.ThrowsAsync<Exception>(() => 
                _spbService.ProcessEventReceivedAsync(FakeSpbEvent.SpbEventInvalidEventName));

            _spbServiceContext.CheckingAccountService.VerifyNoOtherCalls();
        }

        [Fact]
        public async void ProcessEventReceived_WithNegativeAmount_ShouldThrowExceptionAsync()
        {
            //Arrange
            _spbServiceContext.MockProcessDeposit(FakeSpbEvent.SpbEventValid);

            //Act & Assert
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => 
                _spbService.ProcessEventReceivedAsync(FakeSpbEvent.SpbEventNegativeAmount));

            _spbServiceContext.CheckingAccountService.VerifyNoOtherCalls();
        }
    }
}
