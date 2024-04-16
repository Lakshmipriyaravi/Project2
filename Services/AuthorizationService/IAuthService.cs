using Cafe_management.Models;

namespace Cafe_management.Services.AuthorizationService
{
    public interface IAuthService
    {
        Task<string> Authorize(Login user,string userRole);
    }
}
