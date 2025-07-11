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
    public class BelgeManager : IBelgeService
    {
        private IBelgeDal _belgeDal;

        public BelgeManager(IBelgeDal belgeDal)
        {
            _belgeDal = belgeDal;
        }

        public void Add(Belge belge)
        {
            _belgeDal.Add(belge);
        }

        public async Task AddAsync(Belge belge)
        {
            await _belgeDal.AddAsync(belge);
        }

        public void Delete(int belgeId)
        {
            _belgeDal.Delete(new Belge { Id = belgeId });
        }

        public List<Belge> GetAll()
        {
            return _belgeDal.GetList();
        }

        public Belge GetById(int belgeId)
        {
            return _belgeDal.Get(p => p.Id == belgeId);
        }

        public void Update(Belge belge)
        {
            _belgeDal.Update(belge);
        }

    }
}