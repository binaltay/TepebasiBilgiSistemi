using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IBaskanMudurlukService
    {
        List<BaskanMudurluk> GetAll();
        void Add(BaskanMudurluk baskanMudurluk);
        Task AddAsync(BaskanMudurluk baskanMudurluk);
        void Update(BaskanMudurluk baskanMudurluk);
        void Delete(int baskanMudurlukId);
        BaskanMudurluk GetById(int baskanMudurlukId);
    }
}
