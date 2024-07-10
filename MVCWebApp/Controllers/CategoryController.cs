using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
