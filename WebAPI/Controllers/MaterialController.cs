using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class MaterialController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}