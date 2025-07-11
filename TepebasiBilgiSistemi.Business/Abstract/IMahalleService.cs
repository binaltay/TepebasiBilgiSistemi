using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IMahalleService
    {
        List<Mahalle> GetAll();
        void Add(Mahalle mahalle);
        Task AddAsync(Mahalle mahalle);
        void Update(Mahalle mahalle);
        void Delete(int mahalleId);
        Mahalle GetById(int mahalleId);
    }
}
