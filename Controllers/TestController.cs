using LMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        var test = new TestViewModel
        {
            Name = "Pranav",
            DateOfBirth = new DateTime(2000,5,23)
        };
        return View(test);
    }
}