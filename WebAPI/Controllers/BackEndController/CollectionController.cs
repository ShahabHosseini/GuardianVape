using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
using static System.Net.WebRequestMethods;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollectionController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _webHostEnvironment;




        private ICollectionService _collectionService;
        public CollectionController(ILogger<AuthController> logger, ICollectionService collectionService, IConfiguration config, IWebHostEnvironment webHostEnvironment)
        {
            _config = config;
            _collectionService = collectionService;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpGet("condition-type")]
        public async Task<IActionResult> GetCollectios()
        {
            return Ok(await _collectionService.GetAllConditionTypeAsync());
        }

        [HttpGet("equal-type")]
        public async Task<IActionResult> GetEqualTypes()
        {
            return Ok(await _collectionService.GetAllEqualTypeAsync());
        }

        [HttpPost("save-collection")]
        public async Task<IActionResult> SaveCollection(CollectionDto collectionDto)
        {
            await _collectionService.Save(collectionDto);
            return Ok();
        }

        [HttpPost("update-collection")]
        public async Task<IActionResult> UpdateCollection(CollectionDto collectionDto)
        {
            await _collectionService.Update(collectionDto);
            return Ok();
        }

        [HttpPost("get-collection/{guid}")]
        public async Task<IActionResult> GetCollection(string guid)
        {
            return Ok(await _collectionService.GetCollectionAsync(guid));
        }

        [HttpGet("get-collections")]
        public async Task<IActionResult> GetCollectionsAll()
        {
            string HostUrl = "https://localhost:7278/";

            var res = await _collectionService.GetCollectionsAllAsync();

            // Construct the complete URL for each image file and update ImageDto objects
            for (int i = 0; i < res.Count; i++)
            {
                var collections = res[i];
                string relativePath = collections?.Image?.Url.Replace(_webHostEnvironment.WebRootPath, "").Replace("\\", "/");
                string imageUrl = HostUrl.TrimEnd('/') + relativePath;

                // Update the Url property of the existing ImageDto object
                if (collections.Image != null)
                {
                    if (collections.Image.Url != string.Empty)
                    {
                        collections.Image.Url = imageUrl;
                    }
                    else
                    {
                        collections.Image.Url = "https://localhost:7278/Image/default.png";
                    }
                }
                else
                {
                    collections.Image = new ImageDto { Url = "https://localhost:7278/Image/default.png" };

                }
            }

            return Ok(res);
        }
    }
}


