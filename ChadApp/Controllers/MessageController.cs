using Microsoft.AspNetCore.Mvc;

namespace ChadApp.Controllers;

public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}