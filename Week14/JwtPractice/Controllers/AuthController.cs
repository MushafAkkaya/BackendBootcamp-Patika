using JwtPractice.Context;
using JwtPractice.Dtos;
using JwtPractice.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IdentityAndDataProtectionPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtDbContext _context;
        private readonly JwtHelper _jwtService;

        public AuthController(JwtDbContext context, JwtHelper jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto login)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == login.Email && x.Password == login.Password);

            if (user == null)
            {
                return Unauthorized("User bilgisi bulunamadı.");
            }

            var token = _jwtService.GenerateToken(user);
            return Ok(new { token });
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetEmail()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;

            return Ok();
        }
    }
}
