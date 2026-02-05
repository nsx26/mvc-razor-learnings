using McvRazorLearnings.Models;
using Microsoft.AspNetCore.Mvc;
using MvcRazorLearnings.Models;
using System.Diagnostics;

namespace McvRazorLearnings.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Models()
        {
            return View(new BasicModel());
        }

        public IActionResult AtCSharpBlock()
        {
            return View(new BasicModel());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
