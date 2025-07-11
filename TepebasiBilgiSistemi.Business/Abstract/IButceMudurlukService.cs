using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IButceMudurlukService
    {
        List<ButceMudurluk> GetAll();
        void Add(ButceMudurluk butceMudurluk);
        Task AddAsync(ButceMudurluk butceMudurluk);
        void Update(ButceMudurluk butceMudurluk);
        void Delete(int butceMudurlukId);
        ButceMudurluk GetById(int butceMudurlukId);
    }
}
