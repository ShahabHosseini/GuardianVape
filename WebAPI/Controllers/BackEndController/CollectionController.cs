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
    public class CollectionController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;
        private readonly IConfiguration _config;

        private readonly IEmailService _emailService;


        private ICollectionService _collectionService;
        public CollectionController(ILogger<AuthController> logger, ICollectionService collectionService, IConfiguration config,IEmailService emailService)
        {
            _config = config;
            _collectionService = collectionService;
            _logger = logger;
            _emailService = emailService;
        }


        [HttpGet("condition-type")]
        public async Task<IActionResult> GetCollectios()
        {
            return Ok(await _collectionService.GetAllConditionTypeAsync());
        }

        //[HttpPost("register")]
        //public async Task<IActionResult> RegisterUser([FromBody] UserDto userDto)
        //{
          
        //}

        //[Authorize]
        //[HttpGet]
        //public async Task<ActionResult<UserDto>> GetResultAsync()
        //{
        //    return Ok(await _userService.GetAllAsync());
        //}

        //[HttpPost("refresh")]
        //public async Task<IActionResult> Refresh(TokenApiDto tokenApiDto)
        //{
          

        //}

        //[HttpPost("send-reset-email/{email}")]
        //public async Task<IActionResult> SendEmail(string email)
        //{
            
        //}

        //[HttpPost("reset-password")]
        //public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto) 
        //{
          
        //}

    }
}


