using CustomerCareWebApp.BAL;
using CustomerCareWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCareWebApp.Controllers
{
    public class ACCOUNTController : Controller
    {
      
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                ACCOUNTRepository ACR = new ACCOUNTRepository();
                ACR.GetUser(model);

            }
            return View();
        }
    }
}
