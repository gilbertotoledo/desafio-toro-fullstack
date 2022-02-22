using Domain.Entities.SPB;

namespace UnitTests.Services.Fake
{
    public static class FakeSpbEvent
    {
        public static SpbEvent SpbEventValid = new()
        {
            Event = "TRANSFER",
            Amount = 1000,
            Origin = new()
            {
                Bank = "123",
                Branch = "1234",
                Cpf = "12345678912"
            },
            Target = new()
            {
                Bank = "456",
                Branch = "5678",
                Account = "98765"
            }
        };

        public static SpbEvent SpbEventInvalidEventName = new()
        {
            Event = "DEPOSIT",
            Amount = 1000,
            Origin = new()
            {
                Bank = "123",
                Branch = "1234",
                Cpf = "12345678912"
            },
            Target = new()
            {
                Bank = "456",
                Branch = "5678",
                Account = "98765"
            }
        };

        public static SpbEvent SpbEventNegativeAmount = new()
        {
            Event = "DEPOSIT",
            Amount = -50,
            Origin = new()
            {
                Bank = "123",
                Branch = "1234",
                Cpf = "12345678912"
            },
            Target = new()
            {
                Bank = "456",
                Branch = "5678",
                Account = "98765"
            }
        };
    }
}
