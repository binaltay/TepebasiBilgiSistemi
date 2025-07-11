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
    public class BelgeMudurlukManager : IBelgeMudurlukService
    {
        private IBelgeMudurlukDal _belgeMudurlukDal;

        public BelgeMudurlukManager(IBelgeMudurlukDal belgeMudurlukDal)
        {
            _belgeMudurlukDal = belgeMudurlukDal;
        }

        public void Add(BelgeMudurluk belgeMudurluk)
        {
            _belgeMudurlukDal.Add(belgeMudurluk);
        }

        public async Task AddAsync(BelgeMudurluk belgeMudurluk)
        {
            await _belgeMudurlukDal.AddAsync(belgeMudurluk);
        }

        public void Delete(int belgeMudurlukId)
        {
            _belgeMudurlukDal.Delete(new BelgeMudurluk { Id = belgeMudurlukId });
        }

        public List<BelgeMudurluk> GetAll()
        {
            return _belgeMudurlukDal.GetList();
        }

        public BelgeMudurluk GetById(int belgeMudurlukId)
        {
            return _belgeMudurlukDal.Get(p => p.Id == belgeMudurlukId);
        }

        public void Update(BelgeMudurluk belgeMudurluk)
        {
            _belgeMudurlukDal.Update(belgeMudurluk);
        }

    }
}