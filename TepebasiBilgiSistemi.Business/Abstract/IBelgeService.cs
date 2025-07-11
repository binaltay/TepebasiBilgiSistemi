using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IBelgeService
    {
        List<Belge> GetAll();
        void Add(Belge belge);
        Task AddAsync(Belge belge);
        void Update(Belge belge);
        void Delete(int belgeId);
        Belge GetById(int belgeId);
    }
}
