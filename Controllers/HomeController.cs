using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleOnlineTools.Web.Models;

namespace SimpleOnlineTools.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult JsonTools()
    {
        return View();
    }

    public IActionResult TextCompare()
    {
        return View();
    }

    public IActionResult AgeCalculator()
    {
        return View();
    }

    public IActionResult BmiCalculator()
    {
        return View();
    }

    public IActionResult UnitConverter()
    {
        return View();
    }

    public IActionResult Base64Tools()
    {
        return View();
    }

    public IActionResult LoremIpsum()
    {
        return View();
    }

    public IActionResult WordCounter()
    {
        return View();
    }

    // Code Converter Actions
    public IActionResult JsonToCSharp()
    {
        return View();
    }

    public IActionResult JsonToXml()
    {
        return View();
    }

    public IActionResult JsonToJava()
    {
        return View();
    }

    public IActionResult JsonToPython()
    {
        return View();
    }

    public IActionResult XmlToJson()
    {
        return View();
    }

    public IActionResult CSharpToJson()
    {
        return View();
    }

    public IActionResult JavaToJson()
    {
        return View();
    }

    public IActionResult PythonToJson()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
