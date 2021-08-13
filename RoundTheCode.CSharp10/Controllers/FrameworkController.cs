using Microsoft.AspNetCore.Mvc;
using RoundTheCode.CSharp10.Models;

namespace RoundTheCode.CSharp10.Controllers;

[Route("framework")]
public class FrameworkController : Controller
{
    [HttpGet("record-struct")]
    public IActionResult RecordStruct()
    {
        var framework = new Framework
        {
            Name = ".NET",
            Version = 6,
            CodingLanguage = new CodingLanguage { Name = "C#" }
        };

        return Json(framework);
    }
}
