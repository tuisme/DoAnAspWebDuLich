using Microsoft.AspNetCore.Mvc;

namespace dulichaspnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}