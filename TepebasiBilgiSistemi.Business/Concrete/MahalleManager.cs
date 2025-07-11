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
    public class MahalleManager : IMahalleService
    {
        private IMahalleDal _mahalleDal;

        public MahalleManager(IMahalleDal mahalleDal)
        {
            _mahalleDal = mahalleDal;
        }

        public void Add(Mahalle mahalle)
        {
            _mahalleDal.Add(mahalle);
        }

        public async Task AddAsync(Mahalle mahalle)
        {
            await _mahalleDal.AddAsync(mahalle);
        }

        public void Delete(int mahalleId)
        {
            _mahalleDal.Delete(new Mahalle { Id = mahalleId });
        }

        public List<Mahalle> GetAll()
        {
            return _mahalleDal.GetList();
        }

        public Mahalle GetById(int mahalleId)
        {
            return _mahalleDal.Get(p => p.Id == mahalleId);
        }

        public void Update(Mahalle mahalle)
        {
            _mahalleDal.Update(mahalle);
        }

    }
}