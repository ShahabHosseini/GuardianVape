using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Services;
using Share.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<AuthController> _logger;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _webHostEnvironment;




        private ICollectionService _collectionService;
        public ProductController(ILogger<AuthController> logger, ICollectionService collectionService, IConfiguration config, IWebHostEnvironment webHostEnvironment)
        {
            _config = config;
            _collectionService = collectionService;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }


        [HttpGet("Product-type")]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(await _collectionService.GetAllConditionTypeAsync());
        }

        [HttpGet("equal-type")]
        public async Task<IActionResult> GetEqualTypes()
        {
            return Ok(await _collectionService.GetAllEqualTypeAsync());
        }

        [HttpPost("save-product")]
        public async Task<IActionResult> SaveProduct(CollectionDto collectionDto)
        {
            await _collectionService.Save(collectionDto);
            return Ok();
        }

        [HttpGet("get-parents")]
        public async Task<IActionResult> GetParnts()
        {
            return Ok(await _collectionService.GetParents());
        }

        [HttpPost("update-product")]
        public async Task<IActionResult> UpdateProduct(CollectionDto collectionDto)
        {
            await _collectionService.Update(collectionDto);
            return Ok();
        }

        [HttpPost("get-product/{guid}")]
        public async Task<IActionResult> GetProduct(string guid)
        {
            var collection = await _collectionService.GetCollectionAsync(guid);

            if (collection.Image != null)
            {
                string HostUrl = "https://localhost:7278/";
                string relativePath = collection?.Image?.Url.Replace(_webHostEnvironment.WebRootPath, "").Replace("\\", "/");
                string imageUrl = HostUrl.TrimEnd('/') + relativePath;
                collection.Image.Url = imageUrl;

            }
            return Ok(collection);
        }

        [HttpGet("get-products")]
        public async Task<IActionResult> GetProductsAll()
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


