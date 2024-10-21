using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class ContactController : Controller
{
   

    
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (ContactFormModel model)
    {
        if (ModelState. IsValid)
        {
            return RedirectToAction("Index", "Home");

        }


        return View(model);
    }

}
