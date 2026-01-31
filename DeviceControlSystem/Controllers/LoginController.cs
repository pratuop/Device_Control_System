using Microsoft.AspNetCore.Mvc;

namespace DeviceControlSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
           return  Redirect ("~/Dashboard/index");
        }

        [HttpPost]
        public IActionResult register(string Username, String Email , string Password )
        {
            return View();
        }
    }
}
