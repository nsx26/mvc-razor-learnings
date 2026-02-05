using Microsoft.AspNetCore.Mvc;
using MvcRazorLearnings.Models;

namespace MvcRazorLearnings.Controllers;

public class FormController : Controller
{
    public IActionResult Index()
    {
        return View(new FormInputModel());
    }

    [HttpPost]
    public IActionResult Index(FormInputModel model)
    {
        if (!string.IsNullOrEmpty(model.InputText))
        {
            model.Result = model.InputText;
        }
        return View(model);
    }
}
