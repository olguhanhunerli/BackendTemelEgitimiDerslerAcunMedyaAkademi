using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class CategoryController : Controller
{

    
    public IActionResult Index()
    {
        ViewBag.Category = new List<string>{"Teknoloji", "Eğitim", "Sağlık"};
        return View();
    }

}
