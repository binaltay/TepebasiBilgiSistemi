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
    public class KadroManager : IKadroService
    {
        private IKadroDal _kadroDal;

        public KadroManager(IKadroDal kadroDal)
        {
            _kadroDal = kadroDal;
        }

        public void Add(Kadro kadro)
        {
            _kadroDal.Add(kadro);
        }

        public async Task AddAsync(Kadro kadro)
        {
            await _kadroDal.AddAsync(kadro);
        }

        public void Delete(int kadroId)
        {
            _kadroDal.Delete(new Kadro { Id = kadroId });
        }

        public List<Kadro> GetAll()
        {
            return _kadroDal.GetList();
        }

        public Kadro GetById(int kadroId)
        {
            return _kadroDal.Get(p => p.Id == kadroId);
        }

        public void Update(Kadro kadro)
        {
            _kadroDal.Update(kadro);
        }
    }
}