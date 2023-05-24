using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Service.Contracts.Services;
using Service.Implementations.Servises;
using Share.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private  IAddressService _addressService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<AddressDto> Get(IAddressService addressService)
        {
            _addressService=addressService;
        
            var result= await  addressService.GetAsync(1);
            return result;
        }
    }
}