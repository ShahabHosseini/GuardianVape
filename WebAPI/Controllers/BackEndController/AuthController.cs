using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model.Entities;
using Service.Contracts;
using Service.Contracts.Services;
using Service.Contracts.Utility;
using Service.Implementations.Servises;
using Share.DTO;
using Share.Helper;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using WebAPI.BackEnd.Token;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;
        private readonly IConfiguration _config;

        private readonly IEmailService _emailService;

        private IUserService _userService;
        public AuthController(ILogger<AuthController> logger, IUserService userService,IConfiguration config,IEmailService emailService)
        {
            _config = config;
            _userService = userService;
            _logger = logger;
            _emailService = emailService;
        }


        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(UserDto userDto)
        {
            if (userDto == null) { return BadRequest(); }
            var user = await _userService.GetAsync(userDto);

           // var result = await _userService.GetAsync(userDto);
            if (user == null) { return NotFound(); }
            var jwtToken=new JwtToken(_userService);

            user.Token = jwtToken.CreateJwtToken(user);
            var newAccessToken = user.Token;
            var newRefreshToken = jwtToken.CreateRefreshToken();
            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(5);
             await _userService.UpdateAsync(user);
            return Ok(new  TokenApiDto()  
            {   AccessToken= newAccessToken,
                RefreshToken=newRefreshToken
            });;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
        {
            if (userDto == null) { return BadRequest(new { Message = "User Not Found" }); }
            userDto.Role = "User";
            userDto.Token = "";
            try
            {
                await _userService.AddAsync(userDto);

            }
            catch (Exception ex)
            {

                return BadRequest(new { Message = ex.Message });
            }

            return Ok(new { Message = "User registerd!" });
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetResultAsync()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh(TokenApiDto tokenApiDto)
        {
            var jwtToken = new JwtToken(_userService);

            if (tokenApiDto is null)
                return BadRequest("Invalid Client Request");
            string accessToken = tokenApiDto.AccessToken;
            string refreshToken = tokenApiDto.RefreshToken;
            var principal = jwtToken.GetPrincipleFromExpiredToken(accessToken);
            var username = principal.Identity.Name;
            var user = await _userService.FindAsync(username);
            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest("Invalid Request");
            var newAccessToken = jwtToken.CreateJwtToken(user);
            var newRefreshToken = jwtToken.CreateRefreshToken();
            user.RefreshToken = newRefreshToken;
            await _userService.UpdateAsync(user);
            return Ok(new TokenApiDto()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
            });

        }

        [HttpPost("send-reset-email/{email}")]
        public async Task<IActionResult> SendEmail(string email)
        {
            var user= _userService.GetAllAsync().Result.FirstOrDefault(x=>x.Email==email);
            if (user is null) return NotFound(new
            {
                StatusCode=401,
                Message="Email dosent exist!"
            });
            var tokenByte=RandomNumberGenerator.GetBytes(64);
            var emailToken=Convert.ToBase64String(tokenByte);
            user.ResetPasswordToken=emailToken;
            user.ResetPasswordExpiry=DateTime.Now.AddMinutes(15);
            string from = _config["EmailSettings:From"];
            var emailModel = new EmailDto(email, "Reset Password!!", EmailBody.EmailStringBody(email, emailToken));
           await _emailService.SendEmail(emailModel);
           await _userService.UpdateAsync(user);

            return Ok(new
            {
                StatusCode = 200,
                Message = "Email Sent!"
            });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto) 
        {
            var newToken = resetPasswordDto.EmailToken.Replace(" ", "+");
            var user= _userService.GetAllAsync().Result.FirstOrDefault(x => x.Email == resetPasswordDto.Email);
            if (user is null) return NotFound(new
            {
                StatusCode = 401,
                Message = "User dosent exist!"
            });

            var tokenCode = user.ResetPasswordToken;
            DateTime emailTokenExoiry=user.ResetPasswordExpiry;
            if(tokenCode!=resetPasswordDto.EmailToken || emailTokenExoiry<DateTime.Now)
            {
                return BadRequest(new
                {
                    StatusCode=400,
                    Message="Invalid Reset Link"
                });
            }
            user.Password=PasswordHasher.HashPassword(resetPasswordDto.NewPassword);
            await _userService.UpdateAsync(user);
            return Ok(new
            {
                StatusCode=200,
                Message="Password Reset Successfully!"
            });
        }

    }
}


