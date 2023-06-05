using Microsoft.AspNetCore.Mvc;

namespace CustomerCareWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
