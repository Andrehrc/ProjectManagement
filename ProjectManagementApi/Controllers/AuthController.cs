using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementApi.Models.Models;
using ProjectManagementApi.Repositories.Interfaces;
using ProjectManagementApi.Services;
using ProjectManagementApi.Services.Interfaces;

namespace ProjectManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;

        public AuthController(ITokenService tokenService, IUserRepository userRepository)
        {
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login request)
        {
            var user = _userRepository.ValidateUser(request.Email, request.Password);

            if (user == null)
            {
                return Unauthorized("Invalid credentials.");
            }

            var token = _tokenService.GenerateToken(user.Id.ToString());

            return Ok(new { Token = token });
        }
    }
}
