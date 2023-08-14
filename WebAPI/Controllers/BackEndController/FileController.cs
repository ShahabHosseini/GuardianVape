using Microsoft.AspNetCore.Mvc;
using Service.Contracts.Services;
using Share.DTO;
using SixLabors.ImageSharp; // Use SixLabors.ImageSharp instead of System.Drawing
using SixLabors.ImageSharp.Processing; // Import the ImageSharp.Processing namespace

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

        

[HttpPost("upload-image")]
    public async Task<IActionResult> UploadImage()
    {
        bool results = false;
        try
        {
            var uploadedFiles = Request.Form.Files;

            foreach (var source in uploadedFiles)
            {
                    if (!IsImageFile(source))
                    {
                        return BadRequest("Invalid file type. Only image files are allowed.");
                    }
                    string input = source.FileName;
                string[] sections = input.Split('\\');

                string sectionOne = sections[0]; 
                string sectionTwo = sections[1]; 

                string fileName = sectionTwo;
                string filePath = GetFilePath(sectionOne);

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                string imagePath = Path.Combine(filePath, fileName);
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                using (FileStream stream = System.IO.File.Create(imagePath))
                {
                    await source.CopyToAsync(stream);
                    results = true;
                }

                // Get the width and height of the image using System.Drawing
                int width, height;
                    using (Image img = Image.Load(imagePath))
                    {
                        width = img.Width;
                        height = img.Height;
                    }

                    var image = new ImageDto
                {
                    Name = fileName,
                    Guid = source.Name,
                    Url = imagePath,
                    Width = width,
                    Height = height,
                    Length=source.Length,
                    };
                await _fileService.AddAsync(image);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error uploading images");
            return StatusCode(500, "Error uploading images");
        }
        return Ok(results);
    }
        [NonAction]
        private bool IsImageFile(IFormFile file)
        {
            if (file.ContentType.StartsWith("image/"))
            {
                return true;
            }

            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return allowedExtensions.Contains(extension);
        }

        [NonAction]
        private string GetFilePath(string path)
        {
            return _webHostEnvironment.WebRootPath + "\\Image\\"+path;
        }


        [HttpGet("get-image-all")]
        public IActionResult GetImageAll()
        {

            var imageFiles = _fileService.GetAllAsync().Result;
            string HostUrl = "https://localhost:7278/";

            //// Construct the complete URL for each image file and create ImageDto objects
            foreach (var imageFile in imageFiles)
            {
                string relativePath = imageFile.Url.Replace(_webHostEnvironment.WebRootPath, "").Replace("\\", "/");
                string imageUrl = HostUrl.TrimEnd('/') + relativePath;
                imageFile.Url = imageUrl;
            }

            // Return the list of complete ImageDto objects
            return Ok(imageFiles);
        }

        [HttpPost("remove-image")]
        public async Task<IActionResult> RemoveImages(List<ImageDto> imageDtos)
        {
            try
            {
                foreach (var source in imageDtos)
                {
                    string fileName = source.Name;
                    string filePath = GetFilePath(fileName);
                    string imagePath = filePath + "\\" + fileName;
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    await _fileService.RemoveImage(source);
                }
            }
            catch (Exception ex)
            {
                Ok(ex.Message);
            }
         
                return Ok(imageDtos);
            
        }

        [HttpPost("update-image")]
        public async Task<IActionResult>UpdateImage(ImageDto imageDto)
        {
            try
            {
               await _fileService.UpdateImage(imageDto);
                
            }
            catch (Exception ex)
            {
                Ok(ex.Message);
            }

            return Ok(imageDto);

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