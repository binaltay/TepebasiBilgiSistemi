using Microsoft.AspNetCore.Mvc;
using TepebasiBilgiSistemi.Business.Abstract;
using TepebasiBilgiSistemi.Entities.Concrete;
using TepebasiBilgiSistemi.WebUI.Models.AccountViewModel;
using TepebasiBilgiSistemi.WebUI.Models.MudurlukViewModels;

namespace TepebasiBilgiSistemi.WebUI.Controllers
{
    public class MudurlukController : Controller
    {
        private IMudurlukService _mudurlukService;
        public MudurlukController(IMudurlukService mudurlukService)
        {
            _mudurlukService = mudurlukService;
        }
        public IActionResult Index()
        {
            var model = new MudurlukIndexViewModel
            {
                MudurlukList = _mudurlukService.GetAll()
            };

            return View(model);
        }
        public IActionResult Create()
        {
            var model = new MudurlukAddViewModel
            {
                Mudurluk = new Mudurluk()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Mudurluk mudurluk)
        {
            _mudurlukService.Add(mudurluk);
            return RedirectToAction("Index", "Mudurluk");
        }
        public IActionResult Edit(int Id)
        {
            var model = new MudurlukUpdateViewModel
            {
                Mudurluk = _mudurlukService.GetById(Id)
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Mudurluk mudurluk)
        {
            _mudurlukService.Update(mudurluk);
            return RedirectToAction("Index", "Mudurluk");
        }
    }
}
