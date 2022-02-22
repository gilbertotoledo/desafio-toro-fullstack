using Domain.Entities;
using Domain.Repositories;
using Moq;
using System;
using System.Threading.Tasks;

namespace UnitTests.Services.Context
{
    public class UserServiceContext
    {
        public Mock<IUserRepository> UserRepository;

        public UserServiceContext()
        {
            UserRepository = new Mock<IUserRepository>();
        }

        public void MockCreateAsync()
        {
            UserRepository.Setup(p => p.AddAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask);
        }

        public void MockGetAsync(User user)
        {
            UserRepository.Setup(p => p.GetAsync(It.IsAny<Guid>()))
                .Returns(Task.FromResult(user));
        }

        public void MockGetUserByBankBranchAccountAsync(User user)
        {
            UserRepository.Setup(p => p.GetByBankBranchAccountAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                .Returns(Task.FromResult(user));
        }

        public void MockGetUserByLoginAsync(User user)
        {
            UserRepository.Setup(p => p.GetByUsernameAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(user));
        }


    }
}
