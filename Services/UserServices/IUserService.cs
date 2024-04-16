using Microsoft.AspNetCore.Mvc;
using Cafe_management.Models;

namespace Cafe_management.Services.UserServices
{
    public interface IUserService
    {
        Task<User> Register(User user);
        Task<string> Login(Login user);
        Task<List<User>> GetUsers();
        Task<User> GetUser(int id);

        Task<User> UpdateUser(int id,User user);

        Task<User> DeleteUser(int id);
    }
}
