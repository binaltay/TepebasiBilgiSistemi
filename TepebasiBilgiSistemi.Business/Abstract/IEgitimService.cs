using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IEgitimService
    {
        List<Egitim> GetAll();
        void Add(Egitim egitim);
        Task AddAsync(Egitim egitim);
        void Update(Egitim egitim);
        void Delete(int egitimId);
        Egitim GetById(int egitimId);
    }
}
