using Domain.Services;
using Moq;
using Shouldly;
using UnitTests.Services.Context;
using UnitTests.Services.Fake;
using Xunit;

namespace UnitTests.Services
{
    public class UserServiceTest
    {
        private readonly UserService _userService;
        private readonly UserServiceContext _userServiceContext;

        public UserServiceTest()
        {
            _userServiceContext = new UserServiceContext();
            _userService = new UserService(_userServiceContext.UserRepository.Object);
        }

        [Fact]
        public async void CreateUser_ShouldSucceedAsync()
        {
            //Arrange
            _userServiceContext.MockCreateAsync();

            //Act
            await _userService.CreateAsync(FakeUser.User);

            //Assert
            _userServiceContext.UserRepository.Verify(p => p.AddAsync(FakeUser.User), Times.Once);
        }

        [Fact]
        public async void GetUserById_ShouldCallDependenciesAsync()
        {
            //Arrange
            _userServiceContext.MockGetAsync(FakeUser.User);

            //Act
            _ = await _userService.GetByIdAsync(FakeUser.User.Id);

            //Assert
            _userServiceContext.UserRepository.Verify(p => p.GetAsync(FakeUser.User.Id), Times.Once);
        }

        [Fact]
        public async void GetUserByLogin_WithInvalidPassword_ShouldNotFindUserAndCallDependenciesAsync()
        {
            //Arrange
            _userServiceContext.MockGetUserByLoginAsync(FakeUser.User);
            string password = "invalid_pass";

            //Act
            var user = await _userService.GetByLoginAsync(FakeUser.User.Username, password);

            //Assert
            user.ShouldBeNull();
            _userServiceContext.UserRepository.Verify(p => p.GetByUsernameAsync(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public async void GetUserByBankAccountBranch_ShouldCallDependenciesAsync()
        {
            //Arrange
            _userServiceContext.MockGetUserByBankBranchAccountAsync(FakeUser.User);

            //Act
            _ = await _userService.GetByAccountAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert
            _userServiceContext.UserRepository.Verify(p => p.GetByBankBranchAccountAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }

    }
}
