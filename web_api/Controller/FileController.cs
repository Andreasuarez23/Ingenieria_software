using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers;
[Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly string _storagePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

        public FileController()
        {
            if (!Directory.Exists(_storagePath))
            {
                Directory.CreateDirectory(_storagePath);
            }
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var filePath = Path.Combine(_storagePath, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var fileUploadDto = new FileUploadDto
            {
                FileName = file.FileName,
                FilePath = filePath
            };

            return Ok(fileUploadDto);
        }

        [HttpGet("download/{fileName}")]
        public IActionResult DownloadFile(string fileName)
        {
            var filePath = Path.Combine(_storagePath, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/octet-stream", fileName);
        }

        [HttpDelete("delete/{fileName}")]
        public IActionResult DeleteFile(string fileName)
        {
            var filePath = Path.Combine(_storagePath, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            System.IO.File.Delete(filePath);

            return NoContent();
        }
    }