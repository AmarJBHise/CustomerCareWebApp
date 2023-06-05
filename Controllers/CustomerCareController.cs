using Microsoft.AspNetCore.Mvc;

namespace CustomerCareWebApp.Controllers
{
    public class CustomerCareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
