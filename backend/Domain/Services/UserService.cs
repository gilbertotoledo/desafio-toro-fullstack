using Domain.Entities;
using Domain.Entities.SPB;
using Domain.Repositories;
using Domain.Services.Interfaces;

namespace Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CreateAsync(User user)
        {
            try
            {
                await _userRepository.AddAsync(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<User> GetByIdAsync(Guid Id)
        {
            return await _userRepository.GetAsync(Id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.ListAsync();
        }

        public async Task<User> GetByLoginAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            return user is not null && user.Password == password ? user : default;
        }

        public async Task<User> GetByAccountAsync(string bank, string branch, string account) =>
            await _userRepository.GetByBankBranchAccountAsync(bank, branch, account);

        public async Task MockUserData()
        {
            foreach (var user in Mock.Users)
            {
                await _userRepository.AddAsync(user);
            }
        }
    }
}
