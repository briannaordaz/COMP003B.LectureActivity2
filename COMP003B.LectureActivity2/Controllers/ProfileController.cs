using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity2.Controllers;

public class ProfileController : Controller
{
    // GET
    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Hobbies()
    {
        return View();  
    }
}