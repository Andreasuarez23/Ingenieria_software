using Microsoft.AspNetCore.Mvc;


namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]

public class FileUploadDto
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    public FileUploadDto()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    {
    }

    public string FileName { get; set; }
        public string FilePath { get; set; }
    }