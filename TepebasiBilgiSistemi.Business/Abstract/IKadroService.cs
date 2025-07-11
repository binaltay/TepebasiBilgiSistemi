using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IKadroService
    {
        List<Kadro> GetAll();
        void Add(Kadro kadro);
        Task AddAsync(Kadro kadro);
        void Update(Kadro kadro);
        void Delete(int kadroId);
        Kadro GetById(int kadroId);
    }
}
