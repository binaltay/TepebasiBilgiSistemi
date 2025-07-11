using Microsoft.AspNetCore.Mvc;

namespace TepebasiBilgiSistemi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
