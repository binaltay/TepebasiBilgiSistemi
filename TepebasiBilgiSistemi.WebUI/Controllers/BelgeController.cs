using Microsoft.AspNetCore.Mvc;

namespace TepebasiBilgiSistemi.WebUI.Controllers
{
    public class BelgeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
