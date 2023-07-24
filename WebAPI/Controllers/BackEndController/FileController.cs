using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model.Entities;
using Service.Contracts;
using Service.Contracts.Services;
using Microsoft.AspNetCore.Http;

using Share.DTO;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFileService _fileService;
        public FileController(ILogger<FileController> logger, IWebHostEnvironment webHostEnvironment, IFileService fileService)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _fileService = fileService; 
        }

        [HttpPost("save-image")]
        public async Task<IActionResult> SaveImage(IFormFile file)
        {
            try
            {
                // Check if the file DTO is valid
                if (file == null || file.Length == 0)
                {
                    return BadRequest("Invalid file");
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

        //[HttpPost("upload-image")]
        //public async Task<IActionResult> UploadImage(ImageDto image)
        //{
        //    bool Results = false;
        //    try
        //    {
        //        //foreach (var image in images)
        //        //{
        //            string fileName = image.Name;
        //            string filePath = GetFilePath(fileName);
        //            if (!System.IO.Directory.Exists(filePath))
        //            {
        //                System.IO.Directory.CreateDirectory(filePath);
        //            }
        //            string imagePath = Path.Combine(filePath, fileName);
        //            if (System.IO.File.Exists(imagePath))
        //            {
        //                System.IO.File.Delete(imagePath);
        //            }
        //            await System.IO.File.WriteAllBytesAsync(imagePath, image.File);
        //            Results = true;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error fetching images");
        //        return StatusCode(500, "Error fetching images");
        //    }
        //    return Ok(Results);
        //}
        [HttpPost("upload-image")]
        public async Task<IActionResult> UploadImage([FromForm] object obj)
        {
            bool Results = false;
            try
            {
                var Uploadedfilses = Request.Form.Files;

                foreach (var source in Uploadedfilses)
                {
                    string fileName = source.FileName;
                    string filePath = GetFilePath(fileName);
                    if (!System.IO.Directory.Exists(filePath))
                    {
                        System.IO.Directory.CreateDirectory(filePath);
                    }
                    string imagePath = filePath + "\\" + fileName;
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    using (FileStream stream = System.IO.File.Create(imagePath))
                    {
                        await source.CopyToAsync(stream);
                        Results = true;
                    }
                    var image = new ImageDto
                    {
                        Name = fileName,
                        Guid=source.Name,
                        Url= imagePath,
                    };
                  await  _fileService.AddAsync(image);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching images");
                return StatusCode(500, "Error fetching images");
            }
            return Ok(Results);
        }

        [NonAction]
        private string GetFilePath(string Code)
        {
            return _webHostEnvironment.WebRootPath + "\\Image\\Collection";
        }


        [HttpGet("get-image-all")]
        public IActionResult GetImageAll()
        {
            // Combine the web root path with the image collection path
            string imageCollectionPath = Path.Combine(_webHostEnvironment.WebRootPath, "Image", "Collection");
            string HostUrl = "https://localhost:7278/";

            if (!Directory.Exists(imageCollectionPath))
            {
                return NotFound("Image collection directory not found.");
            }

            // Get all image files from the specified directory
            string[] imageFiles = Directory.GetFiles(imageCollectionPath, "*.jpg")
                                           .Concat(Directory.GetFiles(imageCollectionPath, "*.png"))
                                           .ToArray();

            // Create a list to store the complete image URLs as ImageDto objects
            List<ImageDto> imageDtoList = new List<ImageDto>();

            // Construct the complete URL for each image file and create ImageDto objects
            foreach (string imageFile in imageFiles)
            {
                // Get the relative path of the image file from the web root
                string relativePath = imageFile.Replace(_webHostEnvironment.WebRootPath, "").Replace("\\", "/");

                // Combine the relative path with the host URL to get the complete image URL
                string imageUrl = HostUrl.TrimEnd('/') + relativePath;
                string imageName = Path.GetFileNameWithoutExtension(imageFile);

                // Create the ImageDto object and add it to the list
                ImageDto imageDto = new ImageDto
                {
                    Url = imageUrl,
                    Name = imageName,
                    Alt = string.Empty, // You can set other properties if needed
                    Description = string.Empty,
                    Caption = string.Empty,
                    Guid = string.Empty,
                    //File = null, // File property is not included in the response
                };

                imageDtoList.Add(imageDto);
            }

            // Return the list of complete ImageDto objects
            return Ok(imageDtoList);
        }


        [NonAction]
        private string GetImageByCode(string code)
        {
            string ImageUrl=string.Empty;
            string HostUrl = "https://localhost:7278/";
            string FilePath=GetFilePath(code);
            string ImagePath=FilePath + "\\"+ "GUID";

            return "";
        }

        public class SaveImageResponse
        {
            public string Message { get; set; }
        }
    }
}