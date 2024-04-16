using Cafe_management.Exceptions;
using Cafe_management.Models;
using Cafe_management.Repositories.UserRepository;

namespace Cafe_management.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public async Task<User> Register(User user)
        {
            var us = await _repository.Register(user);
            if (us != null)
            {
                throw new UserAlreadyExistsException("User with this email already exists");
            }
            else
            {
                return us;
            }
        }
        public async Task<string> Login(Login user)
        {
            var us =   await _repository.Login(user);
            if (us == "null")
            {
                throw new InvalidCredentialsException("Email or Password is invalid");
            }
            else
            {
                return us;
            }
        }

        public async Task<List<User>> GetUser()
        {
            return  await _repository.GetUsers();
        }

        public async Task<User> GetUser(int id)
        {
            var us = await _repository.GetUser(id);
            if(us==null)
            {
                throw new UserNotFoundException("User not exists with this id");
            }
            return us;
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            var us = await _repository.UpdateUser(id, user);
            if(us==null)
            {
                throw new UserNotFoundException("User not found with this id");
            }
            else
            {
                return user;
            }
        }

        public async Task<User> DeleteUser(int id)
        {
            var us = await _repository.GetUser(id);
            if(us == null)
            {
                throw new UserNotFoundException("User not exists with this id");
            }
            else
            {
                return await _repository.DeleteUser(us);
            }
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
