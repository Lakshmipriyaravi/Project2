using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Cafe_management.Models;
using Cafe_management.Repositories.UserRepository;
using Cafe_management.Services.UserServices;

namespace Cafe_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        public UsersController(IUserService service)
        {
            _service = service;
            
        }


        
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]User user)
        {

            try
            {
                await _service.Register(user);
                return StatusCode(StatusCodes.Status201Created,"User registered successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login user)
        {
            try
            {
                return Ok(await _service.Login(user));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _service.GetUsers());
        }


        [HttpGet("{id}")]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetUser(int id)
        {
            try
            {
                return Ok(await _service.GetUser(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        //[Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            return Ok(await _service.UpdateUser(id, user));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await _service.DeleteUser(id);
                return Ok("User Deleted Successfully");
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


    }
}
