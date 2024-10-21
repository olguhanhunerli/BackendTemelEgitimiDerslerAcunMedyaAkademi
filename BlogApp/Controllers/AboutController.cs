using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class AboutController : Controller
{

    
    public IActionResult Index()
    {
        return View();
    }

}
