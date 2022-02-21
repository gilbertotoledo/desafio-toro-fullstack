using Domain.Entities;

namespace Domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> CreateAsync(User user);
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid Id);
        Task<User> GetByLoginAsync(string username, string password);
        Task<User> GetByAccountAsync(string bank, string branch, string account);
        Task MockUserData();
    }
}
