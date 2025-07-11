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
    public class KursManager : IKursService
    {
        private IKursDal _kursDal;

        public KursManager(IKursDal kursDal)
        {
            _kursDal = kursDal;
        }

        public void Add(Kurs kurs)
        {
            _kursDal.Add(kurs);
        }

        public async Task AddAsync(Kurs kurs)
        {
            await _kursDal.AddAsync(kurs);
        }

        public void Delete(int kursId)
        {
            _kursDal.Delete(new Kurs { Id = kursId });
        }

        public List<Kurs> GetAll()
        {
            return _kursDal.GetList();
        }

        public Kurs GetById(int kursId)
        {
            return _kursDal.Get(p => p.Id == kursId);
        }

        public void Update(Kurs kurs)
        {
            _kursDal.Update(kurs);
        }

    }
}