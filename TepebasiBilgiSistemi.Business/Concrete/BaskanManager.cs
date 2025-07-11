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
    public class BaskanManager : IBaskanService
    {
        private IBaskanDal _baskanDal;

        public BaskanManager(IBaskanDal baskanDal)
        {
            _baskanDal = baskanDal;
        }

        public void Add(Baskan baskan)
        {
            _baskanDal.Add(baskan);
        }

        public async Task AddAsync(Baskan baskan)
        {
            await _baskanDal.AddAsync(baskan);
        }

        public IEnumerable<Baskan> BaskanFull()
        {
            return _baskanDal.BaskanF();
        }

        public IEnumerable<Baskan> BaskanFullById(int Id)
        {
            return _baskanDal.BaskanFBI(Id);
        }

        public void Delete(int baskanId)
        {
            _baskanDal.Delete(new Baskan { Id = baskanId });
        }

        public List<Baskan> GetAll()
        {
            return _baskanDal.GetList();
        }

        public Baskan GetById(int baskanId)
        {
            return _baskanDal.Get(p => p.Id == baskanId);
        }

        public void Update(Baskan baskan)
        {
            _baskanDal.Update(baskan);
        }

    }
}