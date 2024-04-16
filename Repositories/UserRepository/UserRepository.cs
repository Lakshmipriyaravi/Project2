using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Cafe_management.Data;
using Cafe_management.Models;
using Cafe_management.Services.AuthorizationService;

namespace Cafe_management.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        //YummyNirvanaContext _context = new YummyNirvanaContext();
        private readonly Cafe_managementContext _context;
        public readonly IAuthService _auth;
        public UserRepository(IAuthService auth, Cafe_managementContext context)
        {
            _auth = auth;
            _context = context;

        }







        public async Task<User> Register(User user)
        {
            //user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            var UserExists =   _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (UserExists != null)
            {
                return UserExists;
            }
            else
            {
            _context.Users.Add(user);
            _context.SaveChanges();
            return UserExists;
            }
        }

        public async Task<List<User>> GetUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<string> Login(Login user)
        {
            var userLogin = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email &&  u.Password == user.Password);
            if (userLogin == null)
            {
                return "null";
            }
            var jwt = await _auth.Authorize(user, userLogin.Role);
            return jwt;

        }

        public async Task<User> DeleteUser(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            var us = await _context.Users.FindAsync(id);
            if(us == null)
            {
                return us;
            }
            else
            {
                us.Name = user.Name;
                us.PostelCode = user.PostelCode;
                us.Address = user.Address;
                us.MobileNo = user.MobileNo;
                await _context.SaveChangesAsync();
                return us;

            }
        }

        public Task<List<User>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
