using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Business.Abstract;
using TepebasiBilgiSistemi.DataAccess.Abstract;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Concrete
{
    public class BaskanMudurlukManager : IBaskanMudurlukService
    {
        private IBaskanMudurlukDal _baskanMudurlukDal;

        public BaskanMudurlukManager(IBaskanMudurlukDal baskanMudurlukDal)
        {
            _baskanMudurlukDal = baskanMudurlukDal;
        }

        public void Add(BaskanMudurluk baskanMudurluk)
        {
            _baskanMudurlukDal.Add(baskanMudurluk);
        }

        public async Task AddAsync(BaskanMudurluk baskanMudurluk)
        {
            await _baskanMudurlukDal.AddAsync(baskanMudurluk);
        }

        public void Delete(int baskanMudurlukId)
        {
            _baskanMudurlukDal.Delete(new BaskanMudurluk { Id = baskanMudurlukId });
        }

        public List<BaskanMudurluk> GetAll()
        {
            return _baskanMudurlukDal.GetList();
        }

        public BaskanMudurluk GetById(int baskanMudurlukId)
        {
            return _baskanMudurlukDal.Get(p => p.Id == baskanMudurlukId);
        }

        public void Update(BaskanMudurluk baskanMudurluk)
        {
            _baskanMudurlukDal.Update(baskanMudurluk);
        }

    }
}