using McvRazorLearnings.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MvcRazorLearnings.Controllers;

public class MVCController : Controller
{
    public IActionResult Routes()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
