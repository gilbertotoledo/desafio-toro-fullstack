using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
             _users = new List<User>();
        }

        public async Task AddAsync(User user) =>
            await Task.Run(() => _users.Add(user));

        public async Task<IEnumerable<User>> ListAsync() =>
            await Task.Run(() => { return _users; });

        public async Task<User> GetAsync(Guid Id) => 
            await Task.Run(() => _users.FirstOrDefault(p => p.Id == Id));

        public async Task<User> GetByUsernameAsync(string username) =>
            await Task.Run(() => _users.FirstOrDefault(p => p.Username == username));

        public async Task<User> GetByBankBranchAccountAsync(string bank, string branch, string account) =>
            await Task.Run(() => _users.FirstOrDefault(p => 
                p.CheckingAccount.Bank == bank &&
                p.CheckingAccount.Branch == branch &&
                p.CheckingAccount.Account == account));
    }
}
