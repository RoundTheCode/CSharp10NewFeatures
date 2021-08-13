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

    [HttpGet("constant-interpolated-strings")]
    public JsonResult ConstantInterpolatedStrings()
    {
        const string languageReleasePrefix = "C# 10";
        const string languageRelease = $"{languageReleasePrefix} to be released in November 2021.";

        return Json(languageRelease);
    }

    [HttpGet("extended-property-patterns")]
    public JsonResult ExtendedPropertyPatterns()
    {
        var framework = new Framework
        {
            Name = ".NET",
            Version = 6,
            CodingLanguage = new CodingLanguage { Name = "C#" }
        };

        return Json(GetFullCodingLanguageName(framework));
    }

    public static string GetFullCodingLanguageName(Framework framework) => framework switch
    {
        { CodingLanguage.Name: "C#" } => "C Sharp",
        _ => "(unknown)"
    };
}
