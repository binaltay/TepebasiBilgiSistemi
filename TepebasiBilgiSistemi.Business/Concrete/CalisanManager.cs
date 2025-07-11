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
    public class CalisanManager : ICalisanService
    {
        private ICalisanDal _calisanDal;

        public CalisanManager(ICalisanDal calisanDal)
        {
            _calisanDal = calisanDal;
        }

        public void Add(Calisan calisan)
        {
            _calisanDal.Add(calisan);
        }

        public async Task AddAsync(Calisan calisan)
        {
            await _calisanDal.AddAsync(calisan);
        }

        public void Delete(int calisanId)
        {
            _calisanDal.Delete(new Calisan { Id = calisanId });
        }

        public List<Calisan> GetAll()
        {
            return _calisanDal.GetList();
        }

        public Calisan GetById(int calisanId)
        {
            return _calisanDal.Get(p => p.Id == calisanId);
        }

        public void Update(Calisan calisan)
        {
            _calisanDal.Update(calisan);
        }

    }
}