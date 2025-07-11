using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IEtkinlikService
    {
        List<Etkinlik> GetAll();
        void Add(Etkinlik etkinlik);
        Task AddAsync(Etkinlik etkinlik);
        void Update(Etkinlik etkinlik);
        void Delete(int etkinlikId);
        Etkinlik GetById(int etkinlikId);
    }
}
