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
    public class EtkinlikManager : IEtkinlikService
    {
        private IEtkinlikDal _etkinlikDal;

        public EtkinlikManager(IEtkinlikDal etkinlikDal)
        {
            _etkinlikDal = etkinlikDal;
        }

        public void Add(Etkinlik etkinlik)
        {
            _etkinlikDal.Add(etkinlik);
        }

        public async Task AddAsync(Etkinlik etkinlik)
        {
            await _etkinlikDal.AddAsync(etkinlik);
        }

        public void Delete(int etkinlikId)
        {
            _etkinlikDal.Delete(new Etkinlik { Id = etkinlikId });
        }

        public List<Etkinlik> GetAll()
        {
            return _etkinlikDal.GetList();
        }

        public Etkinlik GetById(int etkinlikId)
        {
            return _etkinlikDal.Get(p => p.Id == etkinlikId);
        }

        public void Update(Etkinlik etkinlik)
        {
            _etkinlikDal.Update(etkinlik);
        }

    }
}