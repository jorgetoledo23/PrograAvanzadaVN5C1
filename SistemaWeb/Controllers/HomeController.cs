using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Models;
using System.Diagnostics;

namespace SistemaWeb.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index() { return View(); }
        

    }
}