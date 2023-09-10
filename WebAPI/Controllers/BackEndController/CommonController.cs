using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Services;
using Service.Implementations.Servises;
using Share.DTO;
using SixLabors.ImageSharp; // Use SixLabors.ImageSharp instead of System.Drawing
using SixLabors.ImageSharp.Processing; // Import the ImageSharp.Processing namespace

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommonController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICountryService _countryService;
        public CommonController(ILogger<FileController> logger, IWebHostEnvironment webHostEnvironment, ICountryService countryService)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _countryService = countryService; 
        }

        [HttpGet("get-all-country")]
        public IActionResult GetAllCountry()
        {

            var imageFiles = _countryService.GetAllAsync().Result;
     
            return Ok(imageFiles);
        }
    }
}