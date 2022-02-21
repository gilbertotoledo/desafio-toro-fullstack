using Infrastructure.CrossCutting;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public CheckingAccount CheckingAccount { get; set; }
        public List<Asset> Assets { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            Cpf = RandomUtils.BuildRandomNumericString(Constants.CPF_LENGHT);
            CheckingAccount = new CheckingAccount();
            Assets = new List<Asset>();
        }
    }
}
