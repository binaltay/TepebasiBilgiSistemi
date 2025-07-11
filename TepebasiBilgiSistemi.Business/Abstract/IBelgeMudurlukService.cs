using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TepebasiBilgiSistemi.Entities.Concrete;

namespace TepebasiBilgiSistemi.Business.Abstract
{
    public interface IBelgeMudurlukService
    {
        List<BelgeMudurluk> GetAll();
        void Add(BelgeMudurluk belgeMudurluk);
        Task AddAsync(BelgeMudurluk belgeMudurluk);
        void Update(BelgeMudurluk belgeMudurluk);
        void Delete(int belgeMudurlukId);
        BelgeMudurluk GetById(int belgeMudurlukId);
    }
}
