using CustomIdentity_Live.Dtos;
using CustomIdentity_Live.Models;
using CustomIdentity_Live.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity_Live.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _service;

        public AuthController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var dto = new AddUserDto
            {
                Email = request.Email,
                Password = request.Password
            };

           var result = await _service.AddUser(dto);

            if (result.IsSucceed)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);
        }
    }
}
