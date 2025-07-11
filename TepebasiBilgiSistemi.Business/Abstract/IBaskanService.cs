using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IBaskanService
    {
        List<Baskan> GetAll();
        void Add(Baskan baskan);
        Task AddAsync(Baskan baskan);
        void Update(Baskan baskan);
        void Delete(int baskanId);
        Baskan GetById(int baskanId);
        IEnumerable<Baskan> BaskanFull();
        IEnumerable<Baskan> BaskanFullById(int Id);
    }
}
