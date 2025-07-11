using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IKursService
    {
        List<Kurs> GetAll();
        void Add(Kurs kurs);
        Task AddAsync(Kurs kurs);
        void Update(Kurs kurs);
        void Delete(int kursId);
        Kurs GetById(int kursId);
    }
}
