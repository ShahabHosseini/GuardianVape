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

        private readonly ILogger<WeatherForecastController> _logger;


        private IAddressService _addressService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAddressService addressService)
        {

            _addressService = addressService;
            _logger = logger;
        }


        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<AddressDto> Get()
        {;

            var result = await _addressService.GetAsync(1);
            return result;
        }
    }
}