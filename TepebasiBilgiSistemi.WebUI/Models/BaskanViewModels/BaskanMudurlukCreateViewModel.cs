using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.WebUI.Models.BaskanViewModels
{
    public class BaskanMudurlukCreateViewModel
    {
        public int BaskanId { get; set; }
        public List<Mudurluk> MudurlukList { get; set; }
        public BaskanMudurluk BaskanMudurluk { get; set; }
    }
}
