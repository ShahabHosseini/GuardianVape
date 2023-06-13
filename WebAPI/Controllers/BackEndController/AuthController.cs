using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Service.Contracts.Services;
using Service.Implementations.Servises;
using Share.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;


        private IUserService _userService;
        public AuthController(ILogger<AuthController> logger, IUserService userService)
        {

            _userService = userService;
            _logger = logger;
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserDto userDto)
        {
            if (userDto == null) { return BadRequest(); }
            var user = await _userService.GetAsync(userDto);

           // var result = await _userService.GetAsync(userDto);
            if (user == null) { return NotFound(); }
            return Ok("Login Success");
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
        {
            if (userDto == null) { return BadRequest("User is null"); }

            await _userService.AddAsync(userDto);

            return Ok("User registerd");
        }
    }
}