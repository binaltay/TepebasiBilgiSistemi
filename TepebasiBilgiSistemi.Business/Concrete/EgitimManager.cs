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
    public class EgitimManager : IEgitimService
    {
        private IEgitimDal _egitimDal;

        public EgitimManager(IEgitimDal egitimDal)
        {
            _egitimDal = egitimDal;
        }

        public void Add(Egitim egitim)
        {
            _egitimDal.Add(egitim);
        }

        public async Task AddAsync(Egitim egitim)
        {
            await _egitimDal.AddAsync(egitim);
        }

        public void Delete(int egitimId)
        {
            _egitimDal.Delete(new Egitim { Id = egitimId });
        }

        public List<Egitim> GetAll()
        {
            return _egitimDal.GetList();
        }

        public Egitim GetById(int egitimId)
        {
            return _egitimDal.Get(p => p.Id == egitimId);
        }

        public void Update(Egitim egitim)
        {
            _egitimDal.Update(egitim);
        }

    }
}