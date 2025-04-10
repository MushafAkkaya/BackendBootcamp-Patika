using IdentityAndDataProtectionPractice.Context;
using IdentityAndDataProtectionPractice.Entites;
using IdentityAndDataProtectionPractice.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAndDataProtectionPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IdentityDbContext _context;
        private readonly IDataProtector _protector;

        public AuthController(IdentityDbContext context, IDataProtectionProvider provider)
        {
            _context = context;
            _protector = provider.CreateProtector("UserPasswordProtector");
        }
        [HttpPost("register")]
        public IActionResult Register(UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var userEntity = new UserEntity
            {
                Email = request.Email,
                Password = _protector.Protect(request.Password)
            };

            _context.Users.Add(userEntity);
            _context.SaveChanges();

            return Ok();
        }
    }
}
