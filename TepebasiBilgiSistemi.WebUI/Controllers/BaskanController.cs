using Microsoft.AspNetCore.Mvc;
using TepebasiBilgiSistemi.Business.Abstract;
using TepebasiBilgiSistemi.Entities.Concrete;
using TepebasiBilgiSistemi.WebUI.Models.BaskanViewModels;

namespace TepebasiBilgiSistemi.WebUI.Controllers
{
    public class BaskanController : Controller
    {
        private IBaskanService _baskanService;
        private IBaskanMudurlukService _baskanMudurlukService;
        private IMudurlukService _mudurlukService;
        private readonly IWebHostEnvironment _environment;
        public BaskanController(IBaskanService baskanService, IWebHostEnvironment environment, IBaskanMudurlukService baskanMudurlukService, IMudurlukService mudurlukService)
        {
            _baskanService = baskanService;
            _environment = environment;
            _baskanMudurlukService = baskanMudurlukService;
            _mudurlukService = mudurlukService;
        }
        public IActionResult Index()
        {
            var model = new BaskanIndexViewModel
            {
                BaskanList = _baskanService.GetAll()
            };

            return View(model);
        }
        public IActionResult Detail(int Id)
        {

            var model = new BaskanDetailsViewModel
            {
                Baskan = _baskanService.BaskanFullById(Id)
            };

            return View(model);
        }
        public IActionResult Create()
        {
            var model = new BaskanAddViewModel
            {
                Baskan = new Baskan()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Baskan baskan, IFormFile baskanPhoto)
        {
            if (baskanPhoto != null)
            {
                var extension = "." + baskanPhoto.FileName.Split('.')[baskanPhoto.FileName.Split('.').Length - 1];
                string fileName = Guid.NewGuid().ToString() + extension;

                if (baskanPhoto == null || baskanPhoto.Length == 0)
                    return Content("file not selected");

                var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/Uploads/baskan",
                            fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await baskanPhoto.CopyToAsync(stream);
                }
                baskan.PhotoLink = fileName;
            }
            else
            {
                baskan.PhotoLink = "default.jpg";
            }

            _baskanService.Add(baskan);
            return RedirectToAction("Index", "Baskan");
        }
        public IActionResult Edit(int Id)
        {
            var model = new BaskanUpdateViewModel
            {
                Baskan = _baskanService.GetById(Id)
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Baskan baskan, IFormFile baskanPhoto) 
        {
            if (baskanPhoto != null)
            {
                var extension = "." + baskanPhoto.FileName.Split('.')[baskanPhoto.FileName.Split('.').Length - 1];
                string fileName = Guid.NewGuid().ToString() + extension;

                string posterPath = Path.Combine(_environment.WebRootPath, "Uploads/baskan/" + baskan.PhotoLink);

                if (System.IO.File.Exists(posterPath))
                {
                    System.IO.File.Delete(posterPath);
                }

                var path = Path.Combine(
                       Directory.GetCurrentDirectory(), "wwwroot/Uploads/baskanyard",
                       fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await baskanPhoto.CopyToAsync(stream);
                }
                baskan.PhotoLink = fileName;
            }
            _baskanService.Update(baskan);
            return RedirectToAction("Index", "Baskan");
        }

        public IActionResult BaskanMudurluk(int Id)
        {

            var model = new BaskanMudurlukCreateViewModel
            {
                BaskanMudurluk = new BaskanMudurluk(),
                MudurlukList = _mudurlukService.GetAll(),
                BaskanId = Id
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BaskanMudurluk(BaskanMudurluk BaskanMudurluk, int Id)
        {
            BaskanMudurluk.BaskanId = Id;
            _baskanMudurlukService.AddAsync(BaskanMudurluk);
            return RedirectToAction("Detail", "Baskan", new { Id = Id });
        }
        public IActionResult BaskanMudurlukDelete(int Id)
        {
            int baskYardId = _baskanMudurlukService.GetById(Id).BaskanId;
            _baskanMudurlukService.Delete(Id);
            return RedirectToAction("Detail", "Baskan", new { Id = baskYardId });
        }
    }
}
