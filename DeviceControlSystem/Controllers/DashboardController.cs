using Microsoft.AspNetCore.Mvc;

namespace DeviceControlSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
