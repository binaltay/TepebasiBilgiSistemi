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
    public class ButceMudurlukManager : IButceMudurlukService
    {
        private IButceMudurlukDal _butceMudurlukDal;

        public ButceMudurlukManager(IButceMudurlukDal butceMudurlukDal)
        {
            _butceMudurlukDal = butceMudurlukDal;
        }

        public void Add(ButceMudurluk butceMudurluk)
        {
            _butceMudurlukDal.Add(butceMudurluk);
        }

        public async Task AddAsync(ButceMudurluk butceMudurluk)
        {
            await _butceMudurlukDal.AddAsync(butceMudurluk);
        }

        public void Delete(int butceMudurlukId)
        {
            _butceMudurlukDal.Delete(new ButceMudurluk { Id = butceMudurlukId });
        }

        public List<ButceMudurluk> GetAll()
        {
            return _butceMudurlukDal.GetList();
        }

        public ButceMudurluk GetById(int butceMudurlukId)
        {
            return _butceMudurlukDal.Get(p => p.Id == butceMudurlukId);
        }

        public void Update(ButceMudurluk butceMudurluk)
        {
            _butceMudurlukDal.Update(butceMudurluk);
        }

    }
}