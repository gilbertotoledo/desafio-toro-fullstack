using Domain.Entities;
using System;

namespace UnitTests.Services.Fake
{
    public static class FakeUser
    {
        public static User User = new()
        {
            Id = Guid.Parse("2000be18-9630-45a3-8f2d-74eebf8a3a0a"),
            Username = "test_user",
            Password = "pass123",
            Name = "User test",
            CheckingAccount = new()
            {
                Bank = "111",
                Branch = "0001",
                Account = "12345"
            }
        };
    }
}
