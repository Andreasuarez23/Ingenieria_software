using Microsoft.AspNetCore.Mvc;


namespace web_api.Controllers;

[ApiController]
[Route("[controller]")]

public record FileUploadDto(string FileName, string FilePath);
