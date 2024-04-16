using Cafe_management.Models;

namespace Cafe_management.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User> Register(User user);
        Task<string> Login(Login user);
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);

        Task<User> DeleteUser(User user);

        Task<User> UpdateUser(int id, User user);


    }
}
