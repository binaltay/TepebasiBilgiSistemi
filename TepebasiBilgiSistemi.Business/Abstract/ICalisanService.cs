using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface ICalisanService
    {
        List<Calisan> GetAll();
        void Add(Calisan calisan);
        Task AddAsync(Calisan calisan);
        void Update(Calisan calisan);
        void Delete(int calisanId);
        Calisan GetById(int calisanId);
    }
}
