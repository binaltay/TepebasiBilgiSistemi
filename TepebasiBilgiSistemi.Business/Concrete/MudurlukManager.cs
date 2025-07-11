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
    public class MudurlukManager : IMudurlukService
    {
        private IMudurlukDal _mudurlukDal;

        public MudurlukManager(IMudurlukDal mudurlukDal)
        {
            _mudurlukDal = mudurlukDal;
        }

        public void Add(Mudurluk mudurluk)
        {
            _mudurlukDal.Add(mudurluk);
        }

        public async Task AddAsync(Mudurluk mudurluk)
        {
            await _mudurlukDal.AddAsync(mudurluk);
        }

        public void Delete(int mudurlukId)
        {
            _mudurlukDal.Delete(new Mudurluk { Id = mudurlukId });
        }

        public List<Mudurluk> GetAll()
        {
            return _mudurlukDal.GetList();
        }

        public Mudurluk GetById(int mudurlukId)
        {
            return _mudurlukDal.Get(p => p.Id == mudurlukId);
        }

        public void Update(Mudurluk mudurluk)
        {
            _mudurlukDal.Update(mudurluk);
        }

    }
}