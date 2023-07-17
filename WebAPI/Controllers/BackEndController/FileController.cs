using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model.Entities;
using Service.Contracts;
using Service.Contracts.Services;
using Microsoft.AspNetCore.Http;

using Share.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private ICollectionService _collectionService;

        public FileController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpPost("save-image")]
        public async Task<IActionResult> SaveImage(IFormFile file)
        {
            try
            {
                // Check if the file DTO is valid
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Read the file content into a byte array
                byte[] fileBytes;
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    fileBytes = memoryStream.ToArray();
                }

                // Save the image file or perform any desired operations

                // Example: Saving the file to disk
                var filePath = "Assets/Image/Collection/" + file.FileName;
                await System.IO.File.WriteAllBytesAsync(filePath, fileBytes);

                // Return a success response
                var response = new SaveImageResponse
                {
                    Message = "Image saved successfully"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                // Handle any exceptions and return an error response
                _logger.LogError(ex, "Error saving image");
                return StatusCode(500, "Error saving image");
            }
        }

    }
    public class SaveImageResponse
    {
        public string Message { get; set; }
    }
}
