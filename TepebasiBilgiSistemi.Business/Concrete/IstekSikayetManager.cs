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
    public class IstekSikayetManager : IIstekSikayetService
    {
        private IIstekSikayetDal _istekSikayetDal;

        public IstekSikayetManager(IIstekSikayetDal istekSikayetDal)
        {
            _istekSikayetDal = istekSikayetDal;
        }

        public void Add(IstekSikayet istekSikayet)
        {
            _istekSikayetDal.Add(istekSikayet);
        }

        public async Task AddAsync(IstekSikayet istekSikayet)
        {
            await _istekSikayetDal.AddAsync(istekSikayet);
        }

        public void Delete(int istekSikayetId)
        {
            _istekSikayetDal.Delete(new IstekSikayet { Id = istekSikayetId });
        }

        public List<IstekSikayet> GetAll()
        {
            return _istekSikayetDal.GetList();
        }

        public IstekSikayet GetById(int istekSikayetId)
        {
            return _istekSikayetDal.Get(p => p.Id == istekSikayetId);
        }

        public void Update(IstekSikayet istekSikayet)
        {
            _istekSikayetDal.Update(istekSikayet);
        }

    }
}