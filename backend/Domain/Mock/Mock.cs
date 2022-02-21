using Domain.Entities;

namespace Domain
{
    public static class Mock
    {
        private static readonly User _userTest = new()
        {
            Id = Guid.Parse("2000be18-9630-45a3-8f2d-74eebf8a3a0a"),
            Name = "Gilberto",
            Username = "gilberto",
            Password = "ggg",
            Cpf = "11111111111",
            CheckingAccount = new() {
                Account = "123",
                Amount = 1000
            },
            Assets = new()
            {
                new Asset() { Symbol = "PETR4", Amount = 10, CurrentPrice = 25.48m },
                new Asset() { Symbol = "MGLU3", Amount = 100, CurrentPrice = 50.90m },
                new Asset() { Symbol = "AZUL4", Amount = 50, CurrentPrice = 37.85m }
            }
        };

        private static readonly List<User> _users = new()
        {
            new User() { Name = "Paulo", Username = "paulo", Password = "ppp" },
            new User() { Name = "Roberto", Username = "roberto", Password = "rrr" },
            new User() { Name = "Afonso", Username = "afonso", Password = "aaa" },
            _userTest
        };

        public static List<User> Users { get { return _users; } }
    }
}
