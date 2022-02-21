using Domain.Entities;

namespace Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<IEnumerable<User>> ListAsync();
        Task<User> GetAsync(Guid Id);
        Task<User> GetByUsernameAsync(string username);
        Task<User> GetByBankBranchAccountAsync(string bank, string branch, string account);
    }
}
